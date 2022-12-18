namespace HomeWork.Data.Entities;

public class Group
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Key { get; set; }

    public virtual List<UserGroup>? Users { get; set; }
    public virtual List<TaskEntity>? Tasks { get; set; }
}