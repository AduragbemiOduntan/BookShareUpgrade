using AutoMapper;
using BookShare.Application.Services.Abstraction;
using BookShare.Domain.Model;
using Microsoft.AspNetCore.Identity;

namespace BookShare.Application.Services.Implementation
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public AuthenticationService(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }
    }
}

