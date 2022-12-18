using System.ComponentModel.DataAnnotations;

namespace HomeWork.BLL.Dtos;
public class CreateGroupDto
{
    [Required]
    public string? Name { get; set; }
}
