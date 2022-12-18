using FluentValidation;
using HomeWork.BLL.Dtos;

namespace HomeWork.Common.Validators;
public class CreateGroupDtoValidator : AbstractValidator<CreateGroupDto>
{
    public CreateGroupDtoValidator()
    {
        RuleFor(groupDto => groupDto.Name).NotNull();
        RuleFor(groupDto => groupDto.Name).Length(3, 30).When(groupDto => groupDto.Name != null);
    }
}
