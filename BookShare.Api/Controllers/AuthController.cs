using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookShare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationService _authService;

        public AuthController(IAuthenticationService services)
        {
            _authService = services;
        }

        [HttpPost("signup")]
        [SwaggerResponse(200, Type = typeof(StandardResponse<string>))]
        [SwaggerResponse(401, Type = typeof(StandardResponse<string>))]
        public async Task<IActionResult> RegisterUser([FromBody] UserSignUpRequestDto requestDto)
        {
            var result = await _authService.RegisterUser(requestDto, Request);
            return Ok(result);
        }



        [HttpPost("login")]
        [SwaggerResponse(200, Type = typeof(StandardResponse<string>))]
        [SwaggerResponse(401, Type = typeof(StandardResponse<string>))]
        public async Task<IActionResult> Login([FromBody] UserLoginRequestDto requestDto)
        {
            var result = await _authService.ValidateAndCreateToken(requestDto);
            return Ok(result);
        }

        [HttpGet("activate-email/{email}")]
        [SwaggerResponse(200, Type = typeof(StandardResponse<string>))]
        [SwaggerResponse(401, Type = typeof(StandardResponse<string>))]
        public async Task<IActionResult> ActivateEmail(string email)
        {
            var result = await _authService.GenerateEmailActivationToken(email, Request);
            return Ok(result);

        }
        [HttpPost("add-admin")]
        [SwaggerResponse(200, Type = typeof(StandardResponse<string>))]
        [SwaggerResponse(401, Type = typeof(StandardResponse<string>))]
        public async Task<IActionResult> AddAmin([FromBody] string email)
        {
            var result = await _authService.AddUserAsAdmin(email);
            return StatusCode(200, result);
        }

        [HttpGet("confirm-email/{email}/{token}")]
        [SwaggerResponse(200, Type = typeof(StandardResponse<string>))]
        [SwaggerResponse(401, Type = typeof(StandardResponse<string>))]
        public async Task<ContentResult> ConfirmEmail(string email, string token)
        {
            string decodedToken = WebUtility.UrlDecode(token);
            var result = await _authService.ConfirmEmailAddress(email, decodedToken);
            
            return result.Succeeded? new ContentResult
            {
                Content = htmlVerified,
                ContentType = "text/html"
            } :
            new ContentResult
            {
                Content = htmlFailed,
                ContentType = "text/html"
            };
        }



        const string htmlVerified = @"
                <!DOCTYPE html>
                    <html lang=""en"">
                    <head>
                        <meta charset=""UTF-8"">
                        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                        <title>Email Verified</title>
                        <style>
                            /* Center the verification container */
                            body {
                                display: flex;
                                justify-content: center;
                                align-items: center;
                                height: 100vh;
                                margin: 0;
                            }

                            /* Style for the white background with shadow */
                            .verification-container {
                                background-color: #ffffff;
                                padding: 20px;
                                text-align: center;
                                border-radius: 5px;
                                box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
                            }

                            /* Style for the checkmark icon */
                            .checkmark {
                                font-size: 48px;
                                color: #00cc00; /* Green color for the checkmark */
                            }

                            /* Style for the ""Email Verified"" text */
                            .verified-text {
                                font-size: 24px;
                                color: #333333;
                                margin-top: 10px;
                            }

                            /* Style for the ""Welcome to DropMate Delivery"" text */
                            .dropmate-text {
                                font-size: 28px;
                                color: #333333;
                                margin-top: 10px;
                                font-weight: bold;
                            }
                        </style>
                    </head>
                    <body>
                        <div class=""verification-container"">
                            <!-- Checkmark icon -->
                            <div class=""checkmark"">&#10003;</div>
        
                            <!-- ""Email Verified"" text -->
                            <div class=""verified-text"">Verified Successfully</div>
        
                            <!-- ""Welcome to DropMate Delivery"" text -->
                            <div class=""dropmate-text"">Welcome to Book share</div>
                        </div>
                    </body>
                    </html>";
        const string htmlFailed = @"
                <!DOCTYPE html>
                    <html lang=""en"">
                    <head>
                        <meta charset=""UTF-8"">
                        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                        <title>Email Verified</title>
                        <style>
                            /* Center the verification container */
                            body {
                                display: flex;
                                justify-content: center;
                                align-items: center;
                                height: 100vh;
                                margin: 0;
                            }

                            /* Style for the white background with shadow */
                            .verification-container {
                                background-color: #ffffff;
                                padding: 20px;
                                text-align: center;
                                border-radius: 5px;
                                box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
                            }

                            /* Style for the checkmark icon */
                            .checkmark {
                                font-size: 48px;
                                color: #00cc00; /* Green color for the checkmark */
                            }

                            /* Style for the ""Email Verified"" text */
                            .verified-text {
                                font-size: 24px;
                                color: #333333;
                                margin-top: 10px;
                            }

                            /* Style for the ""Welcome to DropMate Delivery"" text */
                            .dropmate-text {
                                font-size: 28px;
                                color: #333333;
                                margin-top: 10px;
                                font-weight: bold;
                            }
                        </style>
                    </head>
                    <body>
                        <div class=""verification-container"">
                            <!-- Checkmark icon -->
                            <div class=""checkmark"">&#x2715;</div>
        
                            <!-- ""Email Verified"" text -->
                            <div class=""verified-text"">Verified Failed</div>
        
                            <!-- ""Welcome to DropMate Delivery"" text -->
                            <div class=""dropmate-text"">Failed</div>
                        </div>
                    </body>
                    </html>";
    }
}
