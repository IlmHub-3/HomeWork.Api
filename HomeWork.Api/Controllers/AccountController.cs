using HomeWork.BLL.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork.BLL.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IUsersService _usersService;

    public AccountController(IUsersService usersService)
    {
        _usersService = usersService;
    }

    [HttpPost("signup")]
    public async Task<IActionResult> SignUp([FromBody] RegisterUserDto registerUserDto)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        await _usersService.SignUpAsync(registerUserDto);

        return Ok();
    }

    [HttpPost("singin")]
    public async Task<IActionResult> SignIn(LoginUserDto loginUserDto)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        await _usersService.SignInAsync(loginUserDto);

        return Ok();
    }
}
