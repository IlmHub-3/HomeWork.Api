using HomeWork.Data.Entities.Enum;

namespace HomeWork.BLL.ViewModels;
public class TaskViewModel
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public ETaskStatus Status { get; set; }
}
