using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Common.Enum;
using Microsoft.AspNetCore.Http;

namespace BookShare.Application.Services.Abstraction
{
    public interface IBookForSaleService
    {
        Task<StandardResponse<ICollection<BookResponseDto>>> GetAllBooksAsync();
        Task<StandardResponse<BookResponseDto>> GetBookByIdAsync(string id);
        Task<StandardResponse<BookResponseDto>> CreateBookAsync(string userId, BookRequestDto bookRequestDto);
        Task<StandardResponse<ICollection<BookResponseDto>>> GetBookByCategoryAsync(BookCategory bookCategory);
        Task<StandardResponse<ICollection<BookResponseDto>>> GetBooksByNameAsync(string bookName);
        Task<StandardResponse<ICollection<BookResponseDto>>> GetBookByKeyWordAsync(string keyword);
        Task<StandardResponse<ICollection<BookResponseDto>>> GetBooksByEducationLevelAsync(EducationLevel educationLevel);
        Task<StandardResponse<ICollection<BookResponseDto>>> GetBooksBySubjectAsync(Subject subject);
        Task<StandardResponse<ICollection<BookResponseDto>>> GetBooksByListingTypeAsync(ListingType listingType);
        Task<StandardResponse<ICollection<BookResponseDto>>> GetBooksByUserId(string id);
        Task<string> UploadBookImageAsync(string id, IFormFile file);
        Task<string> RemoveBookImageAsync(string id);
        Task<StandardResponse<BookUpdateResponseDto>> UpdateBookAsync(string id, BookUpdateRequestDto requestDto);
    }
}
