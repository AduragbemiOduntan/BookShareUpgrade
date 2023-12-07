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

    public async Task<StandardResponse<RequestResponseDto>> CreateRequestAsync(CreateRequestDto requestDto) 
    {
        var books = new List<BookForSale>();
        foreach(var bookId in requestDto.BooksId)
        {
            var book = await _bookRepository.FindByCondition(b => b.BookForSaleId == bookId, true).SingleOrDefaultAsync();
            books.Add(book);
        }
        var request = new Request()
        {
            UserId = requestDto.UserId,
            LocationId = requestDto.LocationId,
            Books = books
        };
        await _requestRepository.CreateAsync(request);
        await _requestRepository.SaveChangesAync();
        var requestResponseDto = _mapper.Map<RequestResponseDto>(request);
        return StandardResponse<RequestResponseDto>.Success("Request created", requestResponseDto, 201);
    }
    public async Task<StandardResponse<IEnumerable<RequestResponseDto>>> GetRequestsByUserId(string userId)
    {
        var request = await _requestRepository.FindByCondition(r=>r.UserId == userId, false).ToListAsync();
        var requestResponseDto = _mapper.Map<IEnumerable<RequestResponseDto>>(request);
        return StandardResponse<IEnumerable<RequestResponseDto>>.Success("Successful", requestResponseDto);
    }
    public async Task<StandardResponse<IEnumerable<RequestResponseDto>>> GetRequestsById(string requestId)
    {
        var requests = await _requestRepository.FindByCondition(r => r.RequestId == requestId, false).ToListAsync();
        var requestResponseDto = _mapper.Map<IEnumerable<RequestResponseDto>>(requests);
        return StandardResponse<IEnumerable<RequestResponseDto>>.Success("Successful", requestResponseDto);
    }
    public async Task<StandardResponse<string>> DeleteRequest(string requestId)
    {
        var request = await _requestRepository.FindByCondition(r=>r.RequestId==requestId, true).SingleOrDefaultAsync();
        if (request is null) { return StandardResponse<string>.Failed($"Request with id {requestId} not found"); }
        _requestRepository.Delete(request);
        var deleteMsg = $"Request with id {requestId} successfully deleted";
        return StandardResponse<string>.Success("Delete Successful", deleteMsg);
    }
}
