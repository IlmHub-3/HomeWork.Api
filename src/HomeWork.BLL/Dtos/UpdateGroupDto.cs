using System.ComponentModel.DataAnnotations;

namespace HomeWork.BLL.Dtos;
public class UpdateGroupDto
{
    [Required]
    public string? Name { get; set; }
}
