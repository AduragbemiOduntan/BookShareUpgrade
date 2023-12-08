using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Common.Enum;

namespace BookShare.Application.Services.Abstraction
{
    public interface ITransporterService
    {
        Task<StandardResponse<TransporterResponseDto>> CreateTransporterAsync(TransporterRequestDto requestDto);
        Task<StandardResponse<TransporterResponseDto>> UpdateTransporterAsync(string id, bool trackChanges, TransporterRequestDto requestDto);
        Task<StandardResponse<TransporterResponseDto>> FindTransporterByIdAsync(string id);
        Task<StandardResponse<IEnumerable<TransporterResponseDto>>> FindTransporterByLocation(string city, string state);
        Task<StandardResponse<IEnumerable<TransporterResponseDto>>> FindAllTransportersAsync();
        Task<StandardResponse<IEnumerable<TransporterResponseDto>>> FindTransporterByCompanyNameAsync(string companyName);
        Task<StandardResponse<TransporterResponseDto>> DeleteTransporterAsync(string id);
    }
}