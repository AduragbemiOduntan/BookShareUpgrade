using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;

namespace BookShare.Application.Services.Abstraction
{
    public interface IBookForSaleService
    {
        Task<StandardResponse<ICollection<BookForSaleDto>>> GetAllBooksAsync();
        Task<StandardResponse<BookForSaleDto>> GetBookByIdAsync(string id);
    }
}
