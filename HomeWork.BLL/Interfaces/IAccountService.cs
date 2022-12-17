using HomeWork.BLL.Dtos;

namespace HomeWork.BLL;

public interface IAccountService
{
    Task SignUpAsync(RegisterUserDto registerUserDto);
    Task SignInAsync(LoginUserDto loginUserDto);
}
