﻿using AutoMapper;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Domain.Model;

namespace BookShare.Application.MappingProfile;

public class MapInitializer : Profile
{
    public MapInitializer()
    {
        CreateMap<Request, RequestResponseDto>().ForMember(dest => dest.Books, opts => opts.MapFrom(src => src.Books));
        CreateMap<DeliveryCreationDto, Delivery>();
        CreateMap<DeliveryUpdateDto, Delivery>();
        CreateMap<Delivery, DeliveryDto>();
        CreateMap<UserSignUpRequestDto, User>();
        CreateMap<User, UserResponseDto>();
    }
}
