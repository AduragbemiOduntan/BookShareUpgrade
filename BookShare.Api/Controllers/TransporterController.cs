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
        [HttpPut("update/transporter")]
        public async Task<IActionResult> UpdateTransporterAsync(string id, TransporterRequestDto RequestDto)
        {
            var result = await _transporterService.UpdateTransporterAsync(id, false, RequestDto);
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
        [HttpGet("by/companyName")]
        public async Task<IActionResult> FindTransporterByCompanyNameAsync(string companyName)
        {
            var result = await _transporterService.FindTransporterByCompanyNameAsync(companyName);
            return Ok(result);
        }
        [HttpGet("get/by/locationId")]
        public async Task<IActionResult> FindTransporterByLocationAsync(string locationId)
        {
            var result = await _transporterService.FindTransporterByLocationIdAsync(locationId);
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