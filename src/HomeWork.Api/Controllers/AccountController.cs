using HomeWork.BLL;
using HomeWork.BLL.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IUsersService _usersService;

    public AccountController(IUsersService usersService)
    {
        _usersService = usersService;
    }


    [Authorize(Policy = "TacherRights")]
    [HttpPost("signup")]
    public async Task<IActionResult> SignUp([FromBody] RegisterUserDto registerUserDto)
    {
        if(!ModelState.IsValid)
            return BadRequest();
        
        await _usersService.SignUpAsync(registerUserDto);

        return Ok();
    }
}
