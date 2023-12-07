using AutoMapper;
using BookShare.Common.Dto.Request;
using BookShare.Domain.Model;

namespace BookShare.Application.MappingProfile
{
    public class MapInitializer : Profile
    {
        protected MapInitializer()
        {
            CreateMap<TransporterRequestDto, Transporter>();
        }
    }
}
