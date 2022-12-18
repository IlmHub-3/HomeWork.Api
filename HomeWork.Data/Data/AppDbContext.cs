using HomeWork.Data.Entities;
using Microsoft.AspNetCore.Identity;
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

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        SeedData(builder);
    }

    private void SeedData(ModelBuilder builder)
    {
        #region Admin
        Dictionary<string, Guid> userRoleInfo = new()
            {
                { "adminId", Guid.Parse("a7cf39582d8948da8b28bc3dd1f15246") },
                { "adminRoleId", Guid.Parse("197f6c7f-3ccb-4a58-ad5e-92c7fa05bf5e") },
                { "teacherId", Guid.Parse("29389e74-daed-4ded-bf99-489512f5fa8e") },
                { "teacherRoleId", Guid.Parse("8d2a2725-5a14-43e6-b7a0-f861bb545fcf") },
                { "studentId",Guid.Parse("14e7f459-bedc-42e0-90f5-610dde2c5b6d") },
                { "studentRoleId",Guid.Parse("6ce79b85-1881-43b4-b36f-7c93a6b69631") },
            };

        Dictionary<string, string> adminInfo = new()
            {
                { "firstName", "John" },
                { "lastName", "Karter" },
                { "email", "john123@gmail.com" },
                { "userName", "admin" },
                { "password", "admin555" }
            };

        var adminEntity = new User()
        {
            Id = userRoleInfo["adminId"],
            FirstName = adminInfo["firstName"],
            LastName = adminInfo["lastName"],
            UserName = adminInfo["userName"],
            NormalizedUserName = adminInfo["userName"].ToUpper(),
            Email = adminInfo["email"],
            NormalizedEmail = adminInfo["email"].ToUpper(),
            EmailConfirmed = true
        };

        PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
        adminEntity.PasswordHash = passwordHasher.HashPassword(adminEntity, adminInfo["password"]);
        #endregion

        #region Teacher
        Dictionary<string, string> teacherInfo = new()
        {
            { "firstName", "Joe" },
            { "lastName", "Roghan" },
            { "email", "roghan123@gmail.com" },
            { "userName", "teacher" },
            { "password", "teacher555" }
        };

        var teacherEntity = new User()
        {
            Id = userRoleInfo["teacherId"],
            FirstName = teacherInfo["firstName"],
            LastName = teacherInfo["lastName"],
            UserName = teacherInfo["userName"],
            NormalizedUserName = teacherInfo["userName"].ToUpper(),
            Email = teacherInfo["email"],
            NormalizedEmail = teacherInfo["email"].ToUpper(),
            EmailConfirmed = true
        };
        teacherEntity.PasswordHash = passwordHasher.HashPassword(teacherEntity, teacherInfo["password"]);
        #endregion

        #region Student
        Dictionary<string, string> studentInfo = new()
        {
            { "firstName", "Boris" },
            { "lastName", "Spaskiy" },
            { "email", "borisjon@gmail.com" },
            { "userName", "student" },
            { "password", "student555" }
        };

        var studentEntity = new User()
        {
            Id = userRoleInfo["studentId"],
            FirstName = studentInfo["firstName"],
            LastName = studentInfo["lastName"],
            UserName = studentInfo["userName"],
            NormalizedUserName = studentInfo["userName"].ToUpper(),
            Email = studentInfo["email"],
            NormalizedEmail = studentInfo["email"].ToUpper(),
            EmailConfirmed = true
        };
        studentEntity.PasswordHash = passwordHasher.HashPassword(studentEntity, studentInfo["password"]);
        #endregion


        builder.Entity<User>().HasData(adminEntity);
        builder.Entity<User>().HasData(teacherEntity);
        builder.Entity<User>().HasData(studentEntity);


        #region AdminRole
        builder.Entity<Role>().HasData(new Role()
        {
            Id = userRoleInfo["adminRoleId"],
            Name = "Admin",
            NormalizedName = "ADMIN".ToUpper(),
            ConcurrencyStamp = userRoleInfo["adminRoleId"].ToString()
        });

        builder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
        {
            RoleId = userRoleInfo["adminRoleId"],
            UserId = userRoleInfo["adminId"]
        });
        #endregion

        #region TeacherRole
        builder.Entity<Role>().HasData(new Role()
        {
            Id = userRoleInfo["teacherRoleId"],
            Name = "Teacher",
            NormalizedName = "Teacher".ToUpper(),
            ConcurrencyStamp = userRoleInfo["teacherRoleId"].ToString()
        });

        builder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
        {
            RoleId = userRoleInfo["teacherRoleId"],
            UserId = userRoleInfo["teacherId"]
        });
        #endregion

        #region StudentRole
        builder.Entity<Role>().HasData(new Role()
        {
            Id = userRoleInfo["studentRoleId"],
            Name = "Student",
            NormalizedName = "Student".ToUpper(),
            ConcurrencyStamp = userRoleInfo["studentRoleId"].ToString()
        });

        builder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
        {
            RoleId = userRoleInfo["studentRoleId"],
            UserId = userRoleInfo["studentId"]
        });
        #endregion

    }
}
