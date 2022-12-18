using HomeWork.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HomeWork.Data.Data;

public class AppDbContext : IdentityDbContext<User, Role, Guid>
{
    public DbSet<TaskEntity>? Tasks { get; set; }
    public DbSet<UserTask>? UserTasks { get; set; }
    public DbSet<Group>? Groups { get; set; }
    public DbSet<UserGroup>? UserGroups { get; set; }
    public DbSet<TaskComment>? TaskComments { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
