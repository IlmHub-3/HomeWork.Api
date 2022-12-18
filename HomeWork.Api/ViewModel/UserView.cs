using HomeWork.Data.Entities;

namespace HomeWork.Api.ViewModel;

public class UserView
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public virtual List<UserGroup>? Groups { get; set; }
    public virtual List<UserTask>? UserTasks { get; set; }
}
