using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Common.Enum;

namespace BookShare.Application.Services.Abstraction
{
    public interface ITransporterService
    {
        Task<StandardResponse<TransportResponseDto>> UpdateTransporterAsync(string id, bool trackChanges, TransporterRequestDto requestDto);
        Task<StandardResponse<TransportResponseDto>> FindTransporterByIdAsync(string id);
        Task<StandardResponse<TransportResponseDto>> DeleteTransporterAsync(string id);
        Task<StandardResponse<IEnumerable<TransportResponseDto>>> FindAllTransportersAsync();
        Task<StandardResponse<IEnumerable<TransportResponseDto>>> FindTransporterByCompanyNameAsync(string companyName);
    }
}
