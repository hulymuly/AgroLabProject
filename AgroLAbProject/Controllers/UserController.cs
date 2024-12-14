using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    [Authorize(Roles = "Admin")]
    public IActionResult GetUsers()
    {
        return Ok(_userService.GetUsers());
    }

    [HttpPost]
    public IActionResult CreateUser([FromBody] User user)
    {
        var createdUser = _userService.CreateUser(user);
        return Ok(createdUser);
    }
}
