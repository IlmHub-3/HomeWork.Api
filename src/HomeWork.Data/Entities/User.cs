using Microsoft.AspNetCore.Identity;

namespace HomeWork.Data.Entities;

public class User : IdentityUser<Guid>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public virtual List<UserGroup>? Groups { get; set; }
    public virtual List<UserTask>? UserTasks { get; set; }
}