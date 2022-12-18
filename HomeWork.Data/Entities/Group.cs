using System.ComponentModel.DataAnnotations.Schema;

namespace HomeWork.Data.Entities;

public class Group
{
    public Guid Id { get; set; }
    public string? Name { get; set; }

    public Guid TeacherId { get; set; }
    [ForeignKey(nameof(TeacherId))]
    public User? Teacher { get; set; }

    public virtual List<UserGroup>? Users { get; set; }
    public virtual List<TaskEntity>? Tasks { get; set; }
}