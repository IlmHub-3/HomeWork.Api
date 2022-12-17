using HomeWork.BLL.Dtos;

namespace HomeWork.BLL;

public interface IUsersService
{
    Task SignUpAsync(RegisterUserDto registerUserDto);
    Task SignInAsync(LoginUserDto loginUserDto);
}
