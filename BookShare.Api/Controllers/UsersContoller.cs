using BookShare.Application.Services.Abstraction;
using BookShare.Common.Dto.Request;
using BookShare.Common.RequestFeature;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] UserCreateRequestDto requestDto)
    {
        var result = await _userService.CreateUser(requestDto);
        return StatusCode(result.StatusCode, result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(string id)
    {
        await _userService.DeleteUser(id, trackChanges: false);
        return NoContent();
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsers([FromQuery] UserRequestParameters requestParameter)
    {
        var result = await _userService.GetAllUsersAsync(requestParameter, trackChanges: false);
        return StatusCode(result.StatusCode, result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(string id)
    {
        var result = await _userService.GetUserByIdAsync(id, trackChanges: false);
        return StatusCode(result.StatusCode, result);
    }

    [HttpGet("by-email/{email}")]
    public async Task<IActionResult> GetUserByEmail(string email)
    {
        var result = await _userService.GetUserByEmailAsync(email, trackChanges: false);
        return StatusCode(result.StatusCode, result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(string id, [FromBody] UserUpdateRequestDto requestDto)
    {
        await _userService.UpdateUser(id, requestDto);
        return NoContent();
    }
}
