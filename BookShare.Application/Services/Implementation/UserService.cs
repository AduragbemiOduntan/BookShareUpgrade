using AutoMapper;
using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Common.RequestFeature;
using BookShare.Domain.Model;
using BookShare.Infrastructure.Repository.Abstraction;
using BookShare.Infrastructure.Repository.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace BookShare.Application.Services.Implementation
{
    public sealed class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly RepositoryBase<User> _repositoryBase;
        private readonly IUserRepository _userRepository;

        public UserService(UserManager<User> userManager, IMapper mapper, IUserRepository userRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<StandardResponse<UserResponseDto>> CreateUser(UserCreateRequestDto requestDto)
        {
            User user = _mapper.Map<User>(requestDto);
            _repositoryBase.CreateAsync(user);
            await _repositoryBase.SaveChangesAync();
            UserResponseDto responseDto = _mapper.Map<UserResponseDto>(user);
            return new StandardResponse<UserResponseDto>(201, true, string.Empty, responseDto);
        }

        public async Task DeleteUser(string id, bool trackChanges)
        {
            User user = await _userRepository.GetByIdAsync(id);
            _repositoryBase.Delete(user);
            await _repositoryBase.SaveChangesAync();
        }

        public Task<StandardResponse<(IEnumerable<UserResponseDto> users, MetaData metaData)>> GetAllUsersAsync(UserRequestParameters requestParameter, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task<StandardResponse<UserResponseDto>> GetUserByEmailAsync(string email, bool trackChanges)
        {
            User user = await _userRepository.GetByEmailAsync(email, trackChanges);
            UserResponseDto userDto = _mapper.Map<UserResponseDto>(user);
            return new StandardResponse<UserResponseDto>(200, true, string.Empty, userDto);
        }

        public async Task<StandardResponse<UserResponseDto>> GetUserByIdAsync(string id, bool trackChanges)
        {
            User user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                UserResponseDto userDto = _mapper.Map<UserResponseDto>(user);
                return new StandardResponse<UserResponseDto>(200, true, string.Empty, userDto);
            }
            else
            {
                return new StandardResponse<UserResponseDto>(404, false, "User not found", null);
            }
        }


        public Task UpdateUser(string id, UserUpdateRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

    }
}
