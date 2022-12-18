using HomeWork.BLL.Dtos;
using HomeWork.BLL.ViewModels;

namespace HomeWork.BLL;

public interface IUsersService
{
    Task SignUpAsync(RegisterUserDto registerUserDto);
    Task SignInAsync(LoginUserDto loginUserDto);
}
