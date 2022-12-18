using System.ComponentModel.DataAnnotations.Schema;

namespace HomeWork.Data.Entities;

public class UserGroup
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    public virtual User? User { get; set; }

    public Guid CourseId { get; set; }
    [ForeignKey(nameof(CourseId))]
    public virtual Group? Course { get; set; }

    public bool IsAdmin { get; set; }
}