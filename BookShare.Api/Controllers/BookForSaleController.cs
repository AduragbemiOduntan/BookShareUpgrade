using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using BookShare.Common.Dto.Response;
using BookShare.Common.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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

        [HttpPost("create-book")]
        public async Task<IActionResult> CreateBook([FromForm] BookRequestDto bookRequestDto)
        {
            var result = await _bookService.CreateBookAsync(bookRequestDto);
            return Ok(result);
        }

        [HttpPost("book-image")]
        public async Task<IActionResult> UploadBookImage(IFormFile file, string id)
        {
            var book = await _bookService.GetBookByIdAsync(id);
            var result = await _bookService.UploadBookImageAsync(id, file);
            return Ok(StandardResponse<object>.Success("Image uploaded successfully", new { imgUrl = result }, 200));
        }
        [HttpGet("all-books")]
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
        [HttpGet("book-category")]
        public async Task<IActionResult> GetBookByCategory(BookCategory bookCategory)
        {
            var result = await _bookService.GetBookByCategoryAsync(bookCategory);
            return Ok(result);
        }
        [HttpGet("book-name")]
        public async Task<IActionResult> GetBookByName(string name)
        {
            var result = await _bookService.GetBooksByNameAsync(name);
            return Ok(result);
        }
        [HttpGet("keyword")]
        public async Task<IActionResult> GetBookByKeyWordAsync(string keyword)
        {
            var result = await _bookService.GetBookByKeyWordAsync(keyword);
            return Ok(result);
        }
        [HttpGet("education-level")]
        public async Task<IActionResult> GetBooksByEducationLevel(EducationLevel educationLevel)
        {
            var result = await _bookService.GetBooksByEducationLevelAsync(educationLevel);
            return Ok(result);
        }
        [HttpGet("subject")]
        public async Task<IActionResult> GetBooksBySubject(Subject subject)
        {
            var result = await _bookService.GetBooksBySubjectAsync(subject);
            return Ok(result);
        }
        [HttpGet("listing-type")]
        public async Task<IActionResult> GetBooksByListingType(ListingType listingType)
        {
            var result = await _bookService.GetBooksByListingTypeAsync(listingType);
            return Ok(result);
        }
         [HttpGet("user-id")]
        public async Task<IActionResult> GetBooksByUserId(string userId)
        {
           // var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _bookService.GetBooksByUserId(userId);
            return Ok(result);
        }



        /*         [HttpGet("user-id")]
                public async Task<IActionResult> GetBooksByUserId(string id)
                {
                    var result = await _bookService.GetBooksByUserId(id);
                    return Ok(result);
                }*/

    }
}
