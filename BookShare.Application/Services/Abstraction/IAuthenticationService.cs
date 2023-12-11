using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Application.Services.Abstraction
{
    public interface IAuthenticationService
    {
        Task<StandardResponse<string>> RegisterUser(UserSignUpRequestDto requestDto, HttpRequest httpRequest);
        Task<StandardResponse<LoginResponseDto>> ValidateAndCreateToken(UserLoginRequestDto requestDto);
        Task<StandardResponse<string>> ConfirmEmailAddress(string email, string token);
        Task<StandardResponse<string>> GenerateEmailActivationToken(string email, HttpRequest httpRequest);
        Task<StandardResponse<string>> AddUserAsAdmin(string email);
        //void SendResetPasswordEmail(string email, string callback_url);
        //Task<string> GeneratePasswordResetToken(string email);
       /* Task ResetPassword(string token, UserLoginDto requestDto);
        Task ChangePassword(string email, ChangePasswordRequestDto requestDto);*/
    }
}
