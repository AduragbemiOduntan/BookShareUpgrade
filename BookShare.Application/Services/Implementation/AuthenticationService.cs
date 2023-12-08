using AutoMapper;
using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Common.Enum;
using BookShare.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BookShare.Application.Services.Implementation
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly IConfiguration _configuration;
        public AuthenticationService(UserManager<User> userManager, IMapper mapper, IEmailService emailService, IConfiguration configuration)
        {
            _userManager = userManager;
            _mapper = mapper;
            _emailService = emailService;
            _configuration = configuration;
        }

        public async Task<StandardResponse<string>> RegisterUser(UserSignUpRequestDto requestDto, HttpRequest httpRequest)
        {
            User user = _mapper.Map<User>(requestDto);
            user.UserName = requestDto.Email;
            IdentityResult result = await _userManager.CreateAsync(user, requestDto.Password);
            if (!result.Succeeded)
            {
                string errors = string.Empty;
                foreach (var error in result.Errors)
                {
                    if (!error.Description.Contains("Username"))
                        errors += error.Description.TrimEnd('.') + ", ";
                }
                return StandardResponse<string>.Failed(errors, 401);
            }
            string role = requestDto.UserType switch
            {
                UserType.Transporter => "Transporter",
                UserType.Admin => "Admin",
                _ => "User",
            };
            if(role == "Transporter")
            {
                //Create Transporter object if this is a transporter
            }
            _userManager.AddToRoleAsync(user, role);
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            string encodedToken = System.Text.Encodings.Web.UrlEncoder.Default.Encode(token);
            string callback_url = httpRequest.Scheme + "://" + httpRequest.Host + $"/api/authentication/confirm-email/{requestDto.Email}/{encodedToken}";

            SendConfirmationEmail(requestDto.Email, callback_url);
            return StandardResponse<string>.Success("Signup successful", null, 200);
        }

        public async Task<StandardResponse<string>> ValidateAndCreateToken(UserLoginRequestDto requestDto)
        {
            User user = await _userManager.FindByEmailAsync(requestDto.Email);
            bool result = await _userManager.CheckPasswordAsync(user, requestDto.Password);
            if (!result)
            {
                return StandardResponse<string>.Failed("Failed", 401);
            }
            if (!(await _userManager.IsEmailConfirmedAsync(user)))
                return StandardResponse<string>.Failed("Email not yet confirm. Check your inbox", 403);
            string token = await CreateToken(user);
            //UserResponseDto userDto = _mapper.Map<UserResponseDto>(user);
            return StandardResponse<string>.Success("Successful", (token));
        }

        private void SendConfirmationEmail(string email, string callback_url)
        {
            string logoUrl = "";
            string title = "Confirm Your Email";
            string body1 = $"<html><body><br/><br/>Please click to confirm your email address for Book share. When you confirm your email you get full access to Book Share services for free.<p/> <a href={callback_url}>Verify Your Email</a> <p/><br/>Thank you for choosing Book Share.<p/><img src={logoUrl}></body></html>";
            string body = $"<html lang=\"en\">\r\n<head>\r\n  <meta charset=\"UTF-8\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n  <title>Email Confirmation - Book Share</title>\r\n  <style>\r\n    body {{\r\n      font-family: 'Arial', sans-serif;\r\n      background-color: #f4f4f4;\r\n      margin: 0;\r\n      padding: 0;\r\n      text-align: center;\r\n    }}\r\n\r\n    .container {{\r\n      max-width: 600px;\r\n      margin: 20px auto;\r\n      background-color: #fff;\r\n      padding: 20px;\r\n      border-radius: 8px;\r\n      box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);\r\n    }}\r\n\r\n    h1 {{\r\n      color: #3498db;\r\n    }}\r\n\r\n    p {{\r\n      color: #555;\r\n      margin: 10px 0;\r\n    }}\r\n\r\n    .btn {{\r\n      display: inline-block;\r\n      padding: 10px 20px;\r\n      background-color: #3498db;\r\n      color: #fff;\r\n      text-decoration: none;\r\n      border-radius: 5px;\r\n      margin-top: 20px;\r\n    }}\r\n\r\n    .logo {{\r\n      display: block;\r\n      margin: 20px auto;\r\n      max-width: 100%;\r\n      height: auto;\r\n    }}\r\n  </style>\r\n</head>\r\n<body>\r\n  <div class=\"container\">\r\n    <!-- Logo -->\r\n    <img class=\"logo\" src=\"{{logoUrl}}\" alt=\"Book Share Logo\" style=\"display: block; margin: 20px auto; max-width: 100%; height: auto;\">\r\n\r\n    <h1>Email Confirmation - Book Share</h1>\r\n    <p>Please click to confirm your email address for Book Share. When you confirm your email, you get full access to Book Share services for free.</p>\r\n    <a class=\"btn\" href=\"{{callback_url}}\">Verify Your Email</a>\r\n    <p>Thank you for choosing Book Share.</p>\r\n  </div>\r\n</body>\r\n</html>";
            _emailService.SendEmail(email, title, body);
        }

        public async Task<StandardResponse<string>> ConfirmEmailAddress(string email, string token)
        {
            string trimedToken = token.Replace(" ", "+");
            User user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return StandardResponse<string>.Failed("User does not exist", 400);
            if (!user.EmailConfirmed)
                return StandardResponse<string>.Failed("User account not confirmed", 401);
            IdentityResult result = await _userManager.ConfirmEmailAsync(user, trimedToken);
            if (!result.Succeeded)
            {
                return StandardResponse<string>.Failed("Failed to confirm user", 400);
            }
            return StandardResponse<string>.Success("Confirmed successfully", "success", 200);
        }

        public async Task<StandardResponse<string>> GenerateEmailActivationToken(string email, HttpRequest httpRequest)
        {
            User user = await _userManager.FindByEmailAsync(email);
            if(user == null)
                return StandardResponse<string>.Failed("User does not exist", 400);
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            string encodedToken = System.Text.Encodings.Web.UrlEncoder.Default.Encode(token);
            string callback_url = httpRequest.Scheme + "://" + httpRequest.Host + $"/api/authentication/confirm-email/{email}/{encodedToken}";

            SendConfirmationEmail(email, callback_url);
            return StandardResponse<string>.Success("Email sent successful", null, 200);
        }


        private async Task<string> CreateToken(User user)
        {
            SigningCredentials signingCredentials = GetServerSigningCredentials();
            List<Claim> claims = await GetClaims(user);
            JwtSecurityToken tokenOptions = GenerateTokenOptions(signingCredentials, claims);
            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }


        private SigningCredentials GetServerSigningCredentials()
        {
            string envSecret = Environment.GetEnvironmentVariable("SECRET");
            byte[] key = Encoding.UTF8.GetBytes(envSecret);
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }
        private async Task<List<Claim>> GetClaims(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                 new Claim(ClaimTypes.Name,user.UserName),
                 new Claim(ClaimTypes.NameIdentifier, user.Id)
            };
            IList<string> roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }
        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            IConfigurationSection jwtSettings = _configuration.GetSection("JwtSettings");
            JwtSecurityToken tokenOptions = new JwtSecurityToken
                (
                    issuer: jwtSettings["validIssuer"],
                    audience: jwtSettings["validAudience"],
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["expires"])),
                    signingCredentials: signingCredentials
                );
            return tokenOptions;
        }
        public async Task<StandardResponse<string>> AddUserAsAdmin(string email)
        {
            User user = await _userManager.FindByEmailAsync(email);
            if(user == null)
                return StandardResponse<string>.Failed("Failed", 400);
            await _userManager.AddToRoleAsync(user, "Admin");
            return StandardResponse<string>.Success("Role added successful", "Successful", 200);
        }
    }
}

