using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Common.RequestFeature;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Application.Services.Abstraction
{
    public interface IUserService
    {
        Task<StandardResponse<UserResponseDto>> GetUserByIdAsync(string id, bool trackChanges);
        Task<StandardResponse<UserResponseDto>> GetUserByEmailAsync(string email, bool trackChanges);
        Task<StandardResponse<(IEnumerable<UserResponseDto> users, MetaData metaData)>> GetAllUsersAsync(UserRequestParameters requestParameter, bool trackChanges);
        Task<StandardResponse<UserResponseDto>> CreateUser(UserCreateRequestDto requestDto);
        Task UpdateUser(string id, UserUpdateRequestDto requestDto);
        Task DeleteUser(string id, bool trackChanges);
    }
}
