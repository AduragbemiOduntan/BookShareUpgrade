using AutoMapper;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Domain.Model;
namespace BookShare.Application.MappingProfile;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MapInitializer : Profile
{
    public MapInitializer()
    {
        CreateMap<DeliveryCreationDto, Delivery>();
        CreateMap<DeliveryUpdateDto, Delivery>();
        CreateMap<Delivery, DeliveryDto>();
        CreateMap<UserSignUpRequestDto, User>();
        CreateMap<User, UserResponseDto>();
        CreateMap<TransporterRequestDto, Transporter>();
        CreateMap<Transporter, TransporterResponseDto>();
        CreateMap<Request, RequestResponseDto>().ForMember(dest => dest.Books, opts => opts.MapFrom(src => src.Books));
        CreateMap<BookForSale, BookRequestDto>();
        CreateMap<BookRequestDto, BookForSale>();
        CreateMap<BookForSale, BookResponseDto>();
    }
}
