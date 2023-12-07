using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;

namespace BookShare.Application.Services.Abstraction;

public interface IRequestService
{
    Task<StandardResponse<RequestResponseDto>> CreateRequestAsync(string userId, CreateRequestDto requestDto);
    Task<StandardResponse<string>> CancelRequest(string userId, string requestId);
    Task<StandardResponse<string>> ConfirmRequestDelivery(string userId, string requestId);
    Task<StandardResponse<string>> ConfirmRequestReceived(string userId, string requestId);
    Task<StandardResponse<IEnumerable<RequestResponseDto>>> GetAllUserRequestsByUserId(string userId);
    Task<StandardResponse<RequestResponseDto>> GetUserRequestByRequestId(string userId, string requestId);
    Task<StandardResponse<IEnumerable<RequestResponseDto>>> GetUserRequestsByDate(string userId, DateOnly requestDate);
    Task<StandardResponse<IEnumerable<RequestResponseDto>>> GetRequestsByDate(DateOnly requestDate);
    Task<StandardResponse<RequestResponseDto>> GetRequestByRequestId(string requestId);
    Task<StandardResponse<string>> DeleteRequest(string userId, string requestId);
    Task<StandardResponse<IEnumerable<RequestResponseDto>>> GetAllRequestsAsync();
}
