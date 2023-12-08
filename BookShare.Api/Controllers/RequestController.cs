using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BookShare.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RequestController : ControllerBase
{
    private readonly IRequestService _requestService;

    public RequestController(IRequestService requestService)
    {
        _requestService = requestService;
    }

    [HttpPost("create-request")]//User
    public async Task<IActionResult> CreateRequest(int id, [FromBody] CreateRequestDto requestDto)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var response = await _requestService.CreateRequestAsync(userId, requestDto);
        return Ok(response);
    }

    [HttpPut("cancel-request/{requestId}")] //User
    public async Task<IActionResult> CancelRequest(string requestId)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var response = await _requestService.CancelRequest(userId, requestId);
        return Ok(response);
    }

    [HttpPut("confirm-request-delivery")]//User
    public async Task<IActionResult> ConfirmRequestDelivery([FromBody] string requestId)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var response = await _requestService.ConfirmRequestDelivery(userId, requestId);
        return Ok(response);
    }

    [HttpPut("confirm-request-received")]//User
    public async Task<IActionResult> ConfirmRequestReceived([FromBody] string requestId)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var response = await _requestService.ConfirmRequestReceived(userId, requestId);
        return Ok(response);
    }

    [HttpGet("user-requests-by-userid")]//User
    public async Task<IActionResult> GetAllUserRequestByUserId()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var response = await _requestService.GetAllUserRequestsByUserId(userId);
        return Ok(response);
    }
    [HttpGet("user-requests-by-userid/admin/{userId}")]//Admin
    public async Task<IActionResult> GetAllUserRequestByUserId([FromQuery] string userId)
    {
        var response = await _requestService.GetAllUserRequestsByUserId(userId);
        return Ok(response);
    }

    [HttpGet("user-request-by-requestid/{requestId}")]//User
    public async Task<IActionResult> GetUserRequestByRequestId([FromQuery] string requestId)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var response = await _requestService.GetUserRequestByRequestId(userId, requestId);
        return Ok(response);
    }

    [HttpGet("user-request-by-requestid/admin/{userId}/{requestId}")]//Admin
    public async Task<IActionResult> GetUserRequestByRequestId([FromQuery] string userId, string requestId)
    {
        var response = await _requestService.GetUserRequestByRequestId(userId, requestId);
        return Ok(response);
    }

    [HttpGet("user-requests-by-date/{requestDate}")]//User
    public async Task<IActionResult> GetUserRequestsByDate([FromQuery] DateOnly requestDate)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var response = await _requestService.GetUserRequestsByDate(userId, requestDate);
        return Ok(response);
    }

    [HttpGet("user-requests-by-date/admin/{userId}/{requestDate}")]//Admin
    public async Task<IActionResult> GetUserRequestsByDate([FromQuery] string userId, DateOnly requestDate)
    {
        var response = await _requestService.GetUserRequestsByDate(userId, requestDate);
        return Ok(response);
    }

    [HttpGet("requests-by-date/admin/{requestDate}")]//Admin
    public async Task<IActionResult> GetAllRequestsByDate(DateOnly requestDate)
    {
        var response = await _requestService.GetRequestsByDate(requestDate);
        return Ok(response);
    }

    [HttpGet("request-by-requestid/admin/{requestId}")]//Admin
    public async Task<IActionResult> GetRequestsByRequestId(string requestId)
    {
        var response = await _requestService.GetRequestByRequestId(requestId);
        return Ok(response);
    }

    [HttpGet("all-requests/admin")]//Admin
    public async Task<IActionResult> GetAllRequests()
    {
        var response = await _requestService.GetAllRequestsAsync();
        return Ok(response);
    }

    [HttpDelete("delete-request/admin")]//Admin
    public async Task<IActionResult> DeleteRequest([FromBody] string userId, string requestId)
    {
        var response = await _requestService.DeleteRequest(userId, requestId);
        return Ok(response);
    }
}
