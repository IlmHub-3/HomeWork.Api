using FluentValidation;
using HomeWork.BLL.Dtos;

namespace HomeWork.Common.Validators;
public class CreateTaskDtoValidator : AbstractValidator<CreateTaskDto>
{
    public CreateTaskDtoValidator()
    {
        RuleFor(taskDto => taskDto.Files).NotNull();
        RuleFor(taskDto => taskDto.Title).Length(3, 50)
            .When(taskDto => taskDto.Title != null);
    }
}
