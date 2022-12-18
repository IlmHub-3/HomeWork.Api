using System.ComponentModel.DataAnnotations;

namespace HomeWork.BLL.Dtos;
public class CreateTaskCommentDto
{
    [Required]
    public string? Comment { get; set; }
    public Guid? ParentId { get; set; }
}
