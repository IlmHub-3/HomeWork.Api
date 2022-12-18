using FluentValidation;
using HomeWork.BLL;
using HomeWork.BLL.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IUsersService _accountService;
    private readonly IValidator<RegisterUserDto> _validator;

    public AccountController(IUsersService accountService, 
        IValidator<RegisterUserDto> validator)
    {
        _accountService = accountService;
        _validator = validator;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterUserDto registerUserDto)
    {
        var validateResult = _validator.Validate(registerUserDto);

        if(!validateResult.IsValid)
            return BadRequest();

        await _accountService.RegisterAsync(registerUserDto);

        return Ok();
    }

    /*[HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginUserDto loginUserDto)
    {

    }*/
}
