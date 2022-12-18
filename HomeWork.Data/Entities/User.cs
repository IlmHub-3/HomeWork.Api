using Microsoft.AspNetCore.Identity;

namespace HomeWork.Data.Entities;

public class User : IdentityUser<Guid>
{
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }

    public virtual List<UserGroup>? Courses { get; set; }
    public virtual List<UserTask>? UserTasks { get; set; }
}