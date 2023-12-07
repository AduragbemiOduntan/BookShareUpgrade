using AutoMapper;
using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Domain.Model;
using BookShare.Infrastructure.Repository.Abstraction;
using BookShare.Infrastructure.Repository.Implementation;
using Microsoft.EntityFrameworkCore;

namespace BookShare.Application.Services.Implementation
{
    public class BookForSaleService : IBookForSaleService
    {
        private readonly IRepositoryBase<BookForSale> _repository;
        private readonly IMapper _mapper;

        public BookForSaleService(IRepositoryBase<BookForSale> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<StandardResponse<ICollection<BookForSaleDto>>> GetAllBooksAsync()
        {
            var books = await _repository.FindAll(false).ToListAsync();
            var booksReturned = _mapper.Map<ICollection<BookForSaleDto>>(books);
            return StandardResponse<ICollection<BookForSaleDto>>.Success($"Request successful ", booksReturned, 200);
        }

        public async Task<StandardResponse<BookForSaleDto>> GetBookByIdAsync(string id)
        {
            var book = await _repository.FindByCondition(x => x.BookForSaleId == id, false)
               .FirstOrDefaultAsync();
            if (book is null)
            {
                var errorMsg = $"This book is not available.";
                return StandardResponse<BookForSaleDto>.Failed(errorMsg, 400);
            }
            if (book.IsDisabled == true)
            {
                var errorMsg = $"This book is disabled due to harmful content.";
                return StandardResponse<BookForSaleDto>.Failed(errorMsg, 400);
            }
            if (book.IsSoldOut == true)
            {
                var errorMsg = $"This book is sold out";
                return StandardResponse<BookForSaleDto>.Failed(errorMsg, 400);
            }
            var bookDto = _mapper.Map<BookForSaleDto>(book);
            return StandardResponse<BookForSaleDto>.Success("Request successful", bookDto, 200);
        }
    }
}
