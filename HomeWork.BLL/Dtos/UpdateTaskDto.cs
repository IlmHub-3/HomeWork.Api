using HomeWork.Data.Entities.Enum;
using System.ComponentModel.DataAnnotations;

namespace HomeWork.BLL.Dtos;
public class UpdateTaskDto
{
    [Required]
    public string? Title { get; set; }
    public string? Description { get; set; }
    public ETaskStatus? Status { get; set; }
}
