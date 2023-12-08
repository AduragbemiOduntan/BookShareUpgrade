using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShare.Api.Controllers
{
    [Route("api/delivery")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private readonly IDeliveryService _deliveryService;
        public DeliveryController(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        [HttpPost("createDelivery")]
        public async Task<IActionResult> createDelivery([FromBody] DeliveryCreationDto deliveryCreationDto)
        {
            var deliveryToReturn = await _deliveryService.CreateDelivery(deliveryCreationDto);

            return Ok(deliveryToReturn);
        }

        [HttpDelete("deleteDelivery/{deliveryId}")]
        public async Task<IActionResult> DeleteDelivery(string  deliveryId)
        {
            await _deliveryService.DeleteDelivery(deliveryId, trackChanges: true);

            return NoContent();
        }

        [HttpGet("allDeliveries")]
        public async Task<IActionResult> GetAllDeliveriesAsync()
        {
            var allDeliveries = await _deliveryService.GetAllDeliveriesAsync(trackChanges: false);
            return Ok(allDeliveries);
        }

        [HttpGet("deliveriesByRequestId/{requestId}")]
        public async Task<IActionResult> GetDeliveryByRequestId(string requestId)
        {
            var deliveries = await _deliveryService.GetAllDeliveriesByRequestId(requestId, trackChanges: false);

            return Ok(deliveries);
        }

        [HttpGet("deliveriesByTransporterId/{transporterId}")]
        public async Task<IActionResult> GetDeliveryByTransporterId(string transporterId)
        {
            var deliveries = await _deliveryService.GetAllDeliveriesByTransporterId(transporterId, trackChanges: false);
            return Ok(deliveries);
        }

        [HttpGet("deliveriesByUserId/{userId}")]
        public async Task<IActionResult> GetDeliveryByUserId(string userId)
        {
            var deliveries = await _deliveryService.GetAllDeliveriesByUserId(userId, trackChanges: false);
            return Ok(deliveries);
        }

        [HttpGet("deliveriesByDeliveryId/{deliveryId}")]
        public async Task<IActionResult> GetDeliveryByDeliveryId(string deliveryId)
        {
            var deliveries = await _deliveryService.GetDeliveryByDeliveryId(deliveryId, trackChanges: false);
            return Ok(deliveries);
        }

        [HttpPut("/update/{deliveryId}")]
        public async Task<IActionResult> UpdateDelivery(string deliveryId, [FromBody] DeliveryUpdateDto deliveryUpdateDto)
        {
            await _deliveryService.UpdateDelivery(deliveryId, deliveryUpdateDto, trackChanges: true);
            return Ok();
        }
    }
}
