using AutoMapper;
using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Common.Enum;
using BookShare.Domain.Model;
using BookShare.Infrastructure.Repository.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BookShare.Application.Services.Implementation
{
    public class BookForSaleService : IBookForSaleService
    {
        private readonly IRepositoryBase<BookForSale> _repository;
        private readonly IMapper _mapper;
        private readonly IPhotoService _photoService;

        public BookForSaleService(IRepositoryBase<BookForSale> repository, IMapper mapper, IPhotoService photoService)
        {
            _repository = repository;
            _mapper = mapper;
            _photoService = photoService;
        }

        /*public async Task<StandardResponse<BookResponseDto>> CreateBookAsync(BookRequestDto bookRequestDto)
        {

            if (bookRequestDto.SellingPrice == null || bookRequestDto.SellingPrice == 0)
            {
                bookRequestDto.ListingType = ListingType.Free;
            }
            else
            {
                bookRequestDto.ListingType = ListingType.Paid;
            }
            *//*var book = _mapper.Map<BookForSale>(bookRequestDto);*//*
            var bookClass = new BookRequestDto();
            bookClass.BookName = bookRequestDto.BookName;
            bookClass.BookDescription = bookRequestDto.BookDescription;
            bookClass.BookCategory = bookRequestDto.BookCategory;
            bookClass.MarketPrice = bookRequestDto.MarketPrice;
            bookClass.SellingPrice = bookRequestDto.SellingPrice;
            bookClass.ListingType = bookRequestDto.ListingType;
            var createdBook = _mapper.Map<BookForSale>(bookClass);
            await _repository.CreateAsync(createdBook);
            await _repository.SaveChangesAync();

            var book = new BookResponseDto();
            string url = await UploadBookImageAsync(createdBook.BookForSaleId, bookRequestDto.ImageUrl);
            book.ImageUrl = url;
            var update = _mapper.Map(book, createdBook);
            _repository.Update(update);
            await _repository.SaveChangesAync();
            *//*var bookDto = _mapper.Map<BookResponseDto>(book);*//*
            return StandardResponse<BookResponseDto>.Success("Creation successful", book, 201);
        }*/

        public async Task<StandardResponse<BookResponseDto>> CreateBookAsync(BookRequestDto bookRequestDto)
        {
            if (bookRequestDto.SellingPrice == null || bookRequestDto.SellingPrice == 0)
            {
                bookRequestDto.ListingType = ListingType.Free;
            }
            else
            {
                bookRequestDto.ListingType = ListingType.Paid;
            }

            var createdBook = _mapper.Map<BookForSale>(bookRequestDto);
            await _repository.CreateAsync(createdBook);
            await _repository.SaveChangesAync();

            var bookDto = _mapper.Map<BookResponseDto>(createdBook);
            string url = await UploadBookImageAsync(createdBook.BookForSaleId, bookRequestDto.ImageUrl);
            bookDto.ImageUrl = url;
            _repository.Update(createdBook);
            await _repository.SaveChangesAync();

            return StandardResponse<BookResponseDto>.Success("Creation successful", bookDto, 201);
        }


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

                var errorMsg = $"Book is disabled";
                return StandardResponse<BookResponseDto>.Failed(errorMsg, 400);
            }
            if (book.IsSoldOut == true)
            {
                var errorMsg = $"This book is sold out";
                return StandardResponse<BookResponseDto>.Failed(errorMsg, 400);
            }
            if (book.IsDeleted == true)
            {
                var errorMsg = $"This book is deleted";
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
        public async Task<StandardResponse<ICollection<BookResponseDto>>> GetBooksByUserId(string id)
        {
            var books = await _repository.FindAll(false).Where(x => x.UserId == id)
               .OrderBy(x => x.BookName).ToListAsync();
            if (books is null || !books.Any())
            {
                var errorMsg = $"No book with the specified user ID exist at the moment.";
                return StandardResponse<ICollection<BookResponseDto>>.Failed(errorMsg, 400);
            }
            if (books is null || !books.Any())
            {
                var errorMsg = $"No book with the specified user ID exist at the moment.";
                return StandardResponse<ICollection<BookResponseDto>>.Failed(errorMsg, 400);
            }
            var result = books.Any().Equals(books.Where(x => x.IsDisabled == true));
            if (books.Any().Equals(books.Where(x => x.IsDisabled == true)))
            {
                foreach (var book in books)
                {
                    /* books.Where(x => x.IsDisabled == true);*/
                    if (book.IsDisabled == true)
                    {
                        string bookId = book.BookForSaleId;
                        string bookName = book.BookName;
                        var message = DisableBookAsync(bookName, bookId);
                    }
                }

                /* var errorMsg = $"Book is disabled due to harmful content.";
                 return StandardResponse<ICollection<BookResponseDto>>.Failed(errorMsg, 400);*/
            }
            /*     if (books.Any().Equals(books.Where(x => x.IsDisabled == true)))
                 {
                     var errorMsg = $"This book is sold out";
                     return StandardResponse<ICollection<BookResponseDto>>.Failed(errorMsg, 400);
                 }*/
            var booksDto = _mapper.Map<ICollection<BookResponseDto>>(books);
            return StandardResponse<ICollection<BookResponseDto>>.Success("Request successful", booksDto, 200);
        }
        /*public async Task<StandardResponse<ICollection<BookResponseDto>>> GetBooksByUserId(string id)
        {
            var books = await _repository.FindAll(false).Where(x => x.UserId == id)
               .OrderBy(x => x.BookName).ToListAsync();
            if (books is null || !books.Any())
            {
                var errorMsg = $"No book with the specified user ID exist at the moment.";
                return StandardResponse<ICollection<BookResponseDto>>.Failed(errorMsg, 400);
            }
            if (books is null || !books.Any())
            {
                var errorMsg = $"No book with the specified user ID exist at the moment.";
                return StandardResponse<ICollection<BookResponseDto>>.Failed(errorMsg, 400);
            }
            var result = books.Any().Equals(books.Where(x => x.IsDisabled == true));
            if (books.Any().Equals(books.Where(x => x.IsDisabled == true)))
            {
                foreach (var book in books)
                {
                    *//* books.Where(x => x.IsDisabled == true);*//*
                    if (book.IsDisabled == true)
                    {
                        string bookId = book.BookForSaleId;
                        string bookName = book.BookName;
                        var message = DisableBookAsync(bookName, bookId);
                    }
                }

               *//* var errorMsg = $"Book is disabled due to harmful content.";
                return StandardResponse<ICollection<BookResponseDto>>.Failed(errorMsg, 400);*//*
            }
       *//*     if (books.Any().Equals(books.Where(x => x.IsDisabled == true)))
            {
                var errorMsg = $"This book is sold out";
                return StandardResponse<ICollection<BookResponseDto>>.Failed(errorMsg, 400);
            }*//*
            var booksDto = _mapper.Map<ICollection<BookResponseDto>>(books);
            return StandardResponse<ICollection<BookResponseDto>>.Success("Request successful", booksDto, 200);
        }*/
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
        public async Task<StandardResponse<ICollection<BookResponseDto>>> GetBooksByListingTypeAsync(ListingType listingType)
        {
            var books = await _repository.FindAll(false).Where(x => x.ListingType == listingType)
             .OrderBy(x => x.BookName).ToListAsync();
            if (books is null || !books.Any())
            {
                var errorMsg = $"No book with the specified listing type {listingType} exist at the moment.";
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

        public async Task<StandardResponse<string>> DisableBookAsync(string bookName, string bookId)
        {
            const int maxCount = 5;
            var book = await _repository.FindByCondition
                (x => x.BookForSaleId == bookId && x.BookName == bookName && x.HarmfulContentCount == maxCount, false)
               .FirstOrDefaultAsync();

            return StandardResponse<string>.Success($"Request successful, however book {book.BookName} has been deactivated", book.BookName.ToString(), 200);
        }

        public async Task<StandardResponse<BookUpdateResponseDto>> UpdateBookAsync(string id, BookUpdateRequestDto requestDto)
        {
            var book = await _repository.FindByCondition(x => x.BookForSaleId == id, false)
               .FirstOrDefaultAsync();
            var bookUpdate = _mapper.Map(requestDto, book);

            _repository.Update(book);
            await _repository.SaveChangesAync();
            var bookResponse = _mapper.Map<BookUpdateResponseDto>(bookUpdate);
            return StandardResponse<BookUpdateResponseDto>.Success("Successful request", bookResponse, 200);
        }

        public async Task<string> UploadBookImageAsync(string id, IFormFile file)
        {
            var book = await _repository.FindByCondition(x => x.BookForSaleId == id, false)
              .FirstOrDefaultAsync();
            string url = _photoService.UploadPhoto(file, id, "BookShareImages");
            book.ImageUrl = url;
            _repository.Update(book);
            await _repository.SaveChangesAync();
            return url;
        }

        public async Task<string> RemoveBookImageAsync(string id)
        {
            var book = await _repository.FindByCondition(x => x.BookForSaleId == id, false)
              .FirstOrDefaultAsync();
            if (book.ImageUrl == null)
            {
                return "Image URL is null";
            }
            bool status = _photoService.RemoveUploadedPhoto(id, "BookShareImages");
            if (!status)
            {
                return "Image delete failed";
            }
            book.ImageUrl = null;
            _repository.Update(book);
            await _repository.SaveChangesAync();
            return "Request successful";
        }
    }
}
