using AutoMapper;
using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Domain.Model;
using BookShare.Infrastructure.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace BookShare.Application.Services.Implementation;

internal sealed class RequestService : IRequestService
{
    private readonly IRepositoryBase<BookForSale> _bookRepository;
    private readonly IRepositoryBase<Request> _requestRepository;
    private readonly IMapper _mapper;

    public RequestService(IMapper mapper, IRepositoryBase<BookForSale> bookRepository, IRepositoryBase<Request> requestRepository)
    {
        _mapper = mapper;
        _bookRepository = bookRepository;
        _requestRepository = requestRepository;
    }

    public async Task<StandardResponse<RequestResponseDto>> CreateRequestAsync(string userId, CreateRequestDto requestDto)
    {
        var books = new List<BookForSale>();
        foreach (var bookId in requestDto.BooksId)
        {
            var book = await _bookRepository.FindByCondition(b => b.BookForSaleId == bookId, true).SingleOrDefaultAsync();
            book.IsSoldOut = true;
            books.Add(book);
        }
        var request = new Request()
        {
            //UserId = userId,
            UserId = requestDto.UserId,
            LocationId = requestDto.LocationId,
            Books = books
        };
        if (requestDto.IsPickUp) { request.IsPickUp = true; }
        await _requestRepository.CreateAsync(request);
        await _requestRepository.SaveChangesAync();
        //call the transport service and delivery service to facilitate delivery
        var requestResponseDto = _mapper.Map<RequestResponseDto>(request);
        return StandardResponse<RequestResponseDto>.Success("Request created", requestResponseDto, 201);
    }
    public async Task<StandardResponse<string>> CancelRequest(string userId, string requestId)
    {
        var request = await _requestRepository.FindByCondition(r => r.RequestId == requestId && r.UserId==userId, true).SingleOrDefaultAsync();
        if (request is null) { return StandardResponse<string>.Failed($"Request with id {requestId} not found"); }
        var books = request.Books;
        foreach (var book in books)
        {
            book.IsSoldOut = false;
        }
        _requestRepository.Delete(request);
        await _requestRepository.SaveChangesAync();
        return StandardResponse<string>.Success("Successful", $"Request wth id {requestId} cancelled.");
    }
    public async Task<StandardResponse<string>> ConfirmRequestDelivery(string userId ,string requestId)
    {
        var request = await _requestRepository.FindByCondition(r=>r.RequestId == requestId && r.UserId==userId, true).SingleOrDefaultAsync();
        if (request is null) { return StandardResponse<string>.Failed("Request not found"); }
        request.IsDelivered = true;
        await _requestRepository.SaveChangesAync();
        return StandardResponse<string>.Success("Successful", "Delivery confirmed. Thanks");
    }
    public async Task<StandardResponse<string>> ConfirmRequestReceived(string userId , string requestId)
    {
        var request = await _requestRepository.FindByCondition(r => r.RequestId == requestId && r.UserId==userId, true).SingleOrDefaultAsync();
        if (request is null) { return StandardResponse<string>.Failed("Request not found"); }
        request.IsReceived = true;
        await _requestRepository.SaveChangesAync();
        return StandardResponse<string>.Success("Successful", "Request receive confirmed. Thanks");
    }
    public async Task<StandardResponse<IEnumerable<RequestResponseDto>>> GetAllUserRequestsByUserId(string userId)
    {
        var request = await _requestRepository.FindByCondition(r => r.UserId == userId, false).ToListAsync();
        var requestResponseDto = _mapper.Map<IEnumerable<RequestResponseDto>>(request);
        return StandardResponse<IEnumerable<RequestResponseDto>>.Success("Successful", requestResponseDto);
    }
    public async Task<StandardResponse<RequestResponseDto>> GetUserRequestByRequestId(string userId, string requestId)
    {
        var requests = await _requestRepository.FindByCondition(r => r.UserId == userId && r.RequestId==requestId, false).SingleOrDefaultAsync();
        if (requests is null) { return StandardResponse<RequestResponseDto>.Failed("Request not found", 404); }
        var requestResponseDto = _mapper.Map<RequestResponseDto>(requests);
        return StandardResponse<RequestResponseDto>.Success("Successful", requestResponseDto);
    }
    public async Task<StandardResponse<IEnumerable<RequestResponseDto>>> GetUserRequestsByDate(string userId, DateOnly requestDate)
    {
        var dateToDateTime = requestDate.ToDateTime(TimeOnly.MaxValue);
        var date = dateToDateTime.Date;
        var requests = await _requestRepository.FindByCondition(r => r.DateAdded.Date == date && r.UserId == userId, false).ToListAsync();
        var requestResponseDto = _mapper.Map<IEnumerable<RequestResponseDto>>(requests);
        return StandardResponse<IEnumerable<RequestResponseDto>>.Success("Successful", requestResponseDto);
    }
    public async Task<StandardResponse<IEnumerable<RequestResponseDto>>> GetRequestsByDate(DateOnly requestDate)
    {
        var dateToDateTime = requestDate.ToDateTime(TimeOnly.MaxValue);
        var date = dateToDateTime.Date;
        var requests = await _requestRepository.FindByCondition(r => r.DateAdded.Date == date, false).ToListAsync();
        var requestResponseDto = _mapper.Map<IEnumerable<RequestResponseDto>>(requests);
        return StandardResponse<IEnumerable<RequestResponseDto>>.Success("Successful", requestResponseDto);
    }
    public async Task<StandardResponse<RequestResponseDto>> GetRequestByRequestId(string requestId)
    {
        var request = await _requestRepository.FindByCondition(r => r.RequestId == requestId, false).SingleOrDefaultAsync();
        if (request is null) { return StandardResponse<RequestResponseDto>.Failed($"Request with id {requestId} not found"); }
        var requestResponseDto = _mapper.Map<RequestResponseDto>(request);
        return StandardResponse<RequestResponseDto>.Success("Successful", requestResponseDto);
    }
    public async Task<StandardResponse<IEnumerable<RequestResponseDto>>> GetAllRequestsAsync()
    {
        var requests = await _requestRepository.FindAll(false).OrderBy(r=>r.DateAdded).ToListAsync();
        var requestResponseDto = _mapper.Map<IEnumerable<RequestResponseDto>>(requests);
        return StandardResponse<IEnumerable<RequestResponseDto>>.Success("Successful", requestResponseDto);
    }
    public async Task<StandardResponse<string>> DeleteRequest(string userId, string requestId)
    {
        var request = await _requestRepository.FindByCondition(r => r.RequestId == requestId && r.UserId==userId, true).SingleOrDefaultAsync();
        if (request is null) { return StandardResponse<string>.Failed($"Request with id {requestId} not found"); }
        var books = request.Books;
        if (!request.IsDelivered)
        {
            foreach (var book in books)
            {
                book.IsSoldOut = false;
                _bookRepository.Update(book);
            }
            await _bookRepository.SaveChangesAync();
        }
        _requestRepository.Delete(request);
        await _requestRepository.SaveChangesAync();
        var deleteMsg = $"Request with id {requestId} successfully deleted";
        return StandardResponse<string>.Success("Delete Successful", deleteMsg);
    }   
}
