using FluentValidation;
using HomeWork.BLL.Dtos;

namespace HomeWork.Common.Validators;
public class UpdateTaskDtoValidator : AbstractValidator<UpdateTaskDto>
{
    public UpdateTaskDtoValidator()
    {
        RuleFor(updateDto => updateDto.Title).NotNull();
        RuleFor(updateDto => updateDto.Title).Length(3, 30).When(updateDto => updateDto.Title != null);
    }
}
