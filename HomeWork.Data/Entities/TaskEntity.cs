using HomeWork.Data.Entities.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeWork.Data.Entities;

public class TaskEntity
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Comment { get; set; }
    public List<string>? TaskFile { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? ResultLoadedDate { get; set; }
    public ETaskStatus Status { get; set; }
    public string? Description { get; set; }
    public Guid GroupId { get; set; }
    [ForeignKey(nameof(GroupId))]
    public virtual Group? Course { get; set; }

    public virtual List<UserTask>? UserTasks { get; set; }
    public virtual List<TaskComment>? Comments { get; set; }
}
