using FluentValidation;
using HomeWork.BLL.Dtos;

namespace HomeWork.BLL.Validators;
public class RegisterUserDtoValidator : AbstractValidator<RegisterUserDto>
{
    public RegisterUserDtoValidator()
    {
        RuleFor(dtoModel => dtoModel.UserName).Length(1,25)
            .When(dtoModel => dtoModel.UserName != null)
            .WithMessage("UserName should not be null or empty");

        RuleFor(dtoModel => dtoModel.Password).NotEmpty()
            .WithMessage("Password should not be null or empty");
        
        RuleFor(dtoModel => dtoModel.FirstName).NotNull()
            .WithMessage("FirstName should not be null or empty");
    }
}
