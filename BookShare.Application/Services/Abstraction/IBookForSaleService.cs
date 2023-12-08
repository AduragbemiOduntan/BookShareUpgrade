using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Common.Enum;

namespace BookShare.Application.Services.Abstraction
{
    public interface IBookForSaleService
    {
        Task<StandardResponse<ICollection<BookResponseDto>>> GetAllBooksAsync();
        Task<StandardResponse<BookResponseDto>> GetBookByIdAsync(string id);
        Task<StandardResponse<BookResponseDto>> CreateBookAsync(BookRequestDto bookRequestDto);
        Task<StandardResponse<ICollection<BookResponseDto>>> GetBookByCategoryAsync(BookCategory bookCategory);
        Task<StandardResponse<ICollection<BookResponseDto>>> GetBooksByNameAsync(string bookName);
        Task<StandardResponse<ICollection<BookResponseDto>>> GetBookByKeyWordAsync(string keyword);
        Task<StandardResponse<ICollection<BookResponseDto>>> GetBooksByEducationLevelAsync(EducationLevel educationLevel);
        Task<StandardResponse<ICollection<BookResponseDto>>> GetBooksBySubjectAsync(Subject subject);

    }
}
