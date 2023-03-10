using HomeWork.BLL.Dtos;
using HomeWork.BLL.ViewModels;
using HomeWork.Data.Entities;
using JFA.DependencyInjection;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HomeWork.BLL;

[Scoped]
public class UsersService : IUsersService
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    public UsersService(UserManager<User> userManager,
        SignInManager<User> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task SignInAsync(LoginUserDto loginUserDto)
    {
        if (await _userManager.Users.AnyAsync(user => user.UserName == loginUserDto.UserName) == false)
            throw new(); //not foud exception

        var signInResult = await _signInManager.PasswordSignInAsync(loginUserDto.UserName,
            loginUserDto.Password, true, false);
            
        if (!signInResult.Succeeded)
            throw new Exception(); //bad request
    }

    public async Task SignUpAsync(RegisterUserDto registerUserDto)
    {
        if (await _userManager.Users.AnyAsync(user => user.UserName == registerUserDto.UserName))
            throw new(); //bad request exception

        var user = registerUserDto.Adapt<User>();

        await _userManager.CreateAsync(user, registerUserDto.Password);

        await _signInManager.SignInAsync(user, isPersistent: true);
    }
}
