using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using BookShare.Common.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransporterController : ControllerBase
    {
        private readonly ITransporterService _transporterService;

        public TransporterController(ITransporterService transporterService)
        {
            _transporterService = transporterService;
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateTransporterAsync(TransporterRequestDto requestDto)
        {
            var result = await _transporterService.CreateTransporterAsync(requestDto);
            return Ok(result);
        }
        [HttpPut("update/transporter")]
        public async Task<IActionResult> UpdateTransporterAsync(string id, TransporterRequestDto requestDto)
        {
            var result = await _transporterService.UpdateTransporterAsync(id, false, requestDto);
            return Ok(result);
        }
        [HttpGet("get/transporter/by/id")]
        public async Task<IActionResult> FindTransporterByIdAsync(string id)
        {
            var result = await _transporterService.FindTransporterByIdAsync(id);
            return Ok(result);
        }
        [HttpGet("get/all")]
        public async Task<IActionResult> FindAllTransporterAsync()
        {
            var result = await _transporterService.FindAllTransportersAsync();
            return Ok(result);
        }
        [HttpGet("get/by/location")]
        public async Task<IActionResult> FindTransporterByLocationAsync(string city, string state)
        {
            var result = await _transporterService.FindTransporterByLocation(city, state);
            return Ok(result);
        }
        [HttpGet("by/companyName")]
        public async Task<IActionResult> FindTransporterByCompanyNameAsync(string companyName)
        {
            var result = await _transporterService.FindTransporterByCompanyNameAsync(companyName);
            return Ok(result);
        }      
        [HttpDelete("delete/transporter")]
        public async Task<IActionResult> DeeleteTransporterAsync(string id)
        {
            var result = await _transporterService.DeleteTransporterAsync(id);
            return Ok(result);
        }
    }
}