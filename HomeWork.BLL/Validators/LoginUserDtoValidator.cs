using FluentValidation;
using HomeWork.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.BLL.Validators;
public class LoginUserDtoValidator : AbstractValidator<LoginUserDto>
{
    public LoginUserDtoValidator()
    {
        RuleFor(dtoModel => dtoModel.UserName).NotNull()
            .WithMessage("UserName should not be null or empty");

        RuleFor(dtoModel => dtoModel.Password).NotNull()
            .WithMessage("Password should not be null or empty");
    }
}
