using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookForSaleController : ControllerBase
    {
        private readonly IBookForSaleService _bookService;

        public BookForSaleController(IBookForSaleService bookService)
        {
            _bookService = bookService;
        }

/*        [HttpPost]
        public async Task<IActionResult> Post(UserLoginRequestDto requestDto)
        {

        }*/

        [HttpGet]
        public async Task<IActionResult> GetAllBooksAsync()
        {
            var result = await _bookService.GetAllBooksAsync();
            return Ok(result);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetBookById(string id)
        {
            var result = await _bookService.GetBookByIdAsync(id);
            return Ok(result);
        }

    }
}
