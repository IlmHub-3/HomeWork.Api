using HomeWork.BLL.Dtos;

namespace HomeWork.BLL;

public interface IUsersService
{
    Task RegisterAsync(RegisterUserDto registerUserDto);
    Task LoginAsync(LoginUserDto loginUserDto);
}
