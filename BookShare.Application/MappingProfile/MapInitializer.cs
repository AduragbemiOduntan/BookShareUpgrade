using AutoMapper;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Application.MappingProfile
{
    public class MapInitializer : Profile
    {
        public MapInitializer()
        {
            CreateMap<UserSignUpRequestDto, User>();
            CreateMap<User, UserResponseDto>();
        }
    }
}
