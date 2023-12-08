using AutoMapper;
using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Common.Enum;
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

        public async Task<StandardResponse<BookResponseDto>> CreateBookAsync(BookRequestDto bookRequestDto)
        {
            try
            {
                if (bookRequestDto.SellingPrice == null || bookRequestDto.SellingPrice.Value == 0)
                {
                    bookRequestDto.ListingType = ListingType.Free;
                }
                else
                {
                    bookRequestDto.ListingType = ListingType.Paid;
                }

                var book = _mapper.Map<BookForSale>(bookRequestDto);
                await _repository.CreateAsync(book);
                await _repository.SaveChangesAync();

                var bookDto = _mapper.Map<BookResponseDto>(book);
                return StandardResponse<BookResponseDto>.Success("Creation successful", bookDto, 201);
            }
            catch (Exception ex)
            {
                return StandardResponse<BookResponseDto>.Failed("An error occurred while creating a book.", 500);
            }
        }


        /*        public async Task<StandardResponse<BookResponseDto>> CreateBookAsync(BookRequestDto bookRequestDto)
                {
                    if (bookRequestDto.SellingPrice.Value == null || bookRequestDto.SellingPrice.Value == 0)
                    {
                        bookRequestDto.ListingType = ListingType.Free;
                    }
                    else
                    {
                        bookRequestDto.ListingType = ListingType.Paid;
                    }
                    var book = _mapper.Map<BookForSale>(bookRequestDto);
                    await _repository.CreateAsync(book);
                    await _repository.SaveChangesAync();
                    var bookDto = _mapper.Map<BookResponseDto>(book);
                    return StandardResponse<BookResponseDto>.Success("Creation successful", bookDto, 201);
                }*/

        public async Task<StandardResponse<ICollection<BookResponseDto>>> GetAllBooksAsync()
        {
            var books = await _repository.FindAll(false).ToListAsync();
            var booksReturned = _mapper.Map<ICollection<BookResponseDto>>(books);
            return StandardResponse<ICollection<BookResponseDto>>.Success($"Request successful ", booksReturned, 200);
        }

        public async Task<StandardResponse<BookResponseDto>> GetBookByIdAsync(string id)
        {
            var book = await _repository.FindByCondition(x => x.BookForSaleId == id, false)
               .FirstOrDefaultAsync();
            if (book is null)
            {
                var errorMsg = $"Book does not exit.";
                return StandardResponse<BookResponseDto>.Failed(errorMsg, 400);
            }
            if (book.IsDisabled == true)
            {
                var errorMsg = $"Book is disabled due to harmful content.";
                return StandardResponse<BookResponseDto>.Failed(errorMsg, 400);
            }
            if (book.IsSoldOut == true)
            {
                var errorMsg = $"This book is sold out";
                return StandardResponse<BookResponseDto>.Failed(errorMsg, 400);
            }
            var bookDto = _mapper.Map<BookResponseDto>(book);
            return StandardResponse<BookResponseDto>.Success("Request successful", bookDto, 200);
        }

        public async Task<StandardResponse<ICollection<BookResponseDto>>> GetBookByCategoryAsync(BookCategory bookCategory)
        {
            var books = await _repository.FindAll(false).Where(x => x.BookCategory == bookCategory)
               .OrderBy(x => x.BookName).ToListAsync();
            if (books is null || !books.Any())
            {
                var errorMsg = $"No book with the specified category {bookCategory} exist at the moment.";
                return StandardResponse<ICollection<BookResponseDto>>.Failed(errorMsg, 400);
            }

            var booksDto = _mapper.Map<ICollection<BookResponseDto>>(books);
            return StandardResponse<ICollection<BookResponseDto>>.Success("Request successful", booksDto, 200);
        }
        public async Task<StandardResponse<ICollection<BookResponseDto>>> GetBooksByNameAsync(string bookName)
        {
            var books = await _repository.FindAll(false).Where(x => x.BookName == bookName)
             .OrderBy(x => x.BookName).ToListAsync();
            if (books is null || !books.Any())
            {
                var errorMsg = $"No book with the specified name {bookName} exist at the moment.";
                return StandardResponse<ICollection<BookResponseDto>>.Failed(errorMsg, 400);
            }

            var booksDto = _mapper.Map<ICollection<BookResponseDto>>(books);
            return StandardResponse<ICollection<BookResponseDto>>.Success("Request successful", booksDto, 200);
        }
        public async Task<StandardResponse<ICollection<BookResponseDto>>> GetBooksByEducationLevelAsync(EducationLevel educationLevel)
        {
            var books = await _repository.FindAll(false).Where(x => x.EducationLevel == educationLevel)
             .OrderBy(x => x.BookName).ToListAsync();
            if (books is null || !books.Any())
            {
                var errorMsg = $"No book with the specified education level {educationLevel} exist at the moment.";
                return StandardResponse<ICollection<BookResponseDto>>.Failed(errorMsg, 400);
            }

            var booksDto = _mapper.Map<ICollection<BookResponseDto>>(books);
            return StandardResponse<ICollection<BookResponseDto>>.Success("Request successful", booksDto, 200);
        }
        public async Task<StandardResponse<ICollection<BookResponseDto>>> GetBooksBySubjectAsync(Subject subject)
        {
            var books = await _repository.FindAll(false).Where(x => x.Subject == subject)
             .OrderBy(x => x.BookName).ToListAsync();
            if (books is null || !books.Any())
            {
                var errorMsg = $"No book with the specified subject {subject} exist at the moment.";
                return StandardResponse<ICollection<BookResponseDto>>.Failed(errorMsg, 400);
            }

            var booksDto = _mapper.Map<ICollection<BookResponseDto>>(books);
            return StandardResponse<ICollection<BookResponseDto>>.Success("Request successful", booksDto, 200);
        }

        public async Task<StandardResponse<ICollection<BookResponseDto>>> GetBookByKeyWordAsync(string keyword)
        {
            /*            var books = await _repository.FindAll(false).Where(x =>
                                x.BookName.Contains(keyword) ||
                                x.BookDescription.Contains(keyword) ||
                                x.Author.Contains(keyword) ||
                                x.Publisher.Contains(keyword) ||
                                x.Subject.ToString().Contains(keyword) == true ||
                                x.ISBN.Contains(keyword) ||
                                x.ListingType.ToString().Contains(keyword) == true
                            ).OrderBy(x => x.BookName).ToListAsync();*/
            foreach (BookCategory category in Enum.GetValues(typeof(BookCategory)))
            {
                var result = category.ToString().Contains(keyword);
            }
            var books = await _repository.FindAll(false)
         .Where(x =>
             x.BookName.Contains(keyword) ||
             x.BookDescription.Contains(keyword) ||
             x.Author.Contains(keyword) ||
             x.Publisher.Contains(keyword) ||
         /*    x.Subject.CompareTo(keyword).ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase) ||*/ 
             x.ISBN.Contains(keyword)
         /*    x.ListingType.CompareTo(keyword).ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase) */
         )
         .OrderBy(x => x.BookName)
         .ToListAsync();
            if (books is null || !books.Any())
            {
                var errorMsg = $"No books found for the specified keyword {keyword}";
                return StandardResponse<ICollection<BookResponseDto>>.Failed(errorMsg, 400);
            }

            var booksDto = _mapper.Map<ICollection<BookResponseDto>>(books);
            return StandardResponse<ICollection<BookResponseDto>>.Success("Request successful", booksDto, 200);
        }

    }
}
