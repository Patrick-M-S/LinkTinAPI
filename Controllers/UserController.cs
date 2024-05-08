using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUser(long id)
    {
        var user = await _userService.GetUserAsync(id);
        if (user == null)
        {
            return BadRequest();
        }
        return Ok(user);
    }
}