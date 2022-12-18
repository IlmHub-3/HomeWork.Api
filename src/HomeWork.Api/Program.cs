using HomeWork.BLL;
using HomeWork.Data.Data;
using HomeWork.Data.Entities;
using Microsoft.EntityFrameworkCore;
using JFA.DependencyInjection;
using Microsoft.Extensions.Logging;
using Castle.Core.Logging;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUsersService, UsersService>();

builder.Services.AddCors();
builder.Services.AddServicesFromAttribute();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddIdentity<User, Role>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;

}).AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddAuthorization(option =>
{
    option.AddPolicy("TacherRights", policyOption =>
    {
        policyOption.RequireRole("Teacher").RequireClaim("IsActive");
    });
});

builder.Services.AddCors(option =>
{
    option.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("http://example.com",
                                              "http://www.contoso.com");
        });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.UseCors();

app.MapControllers();

app.Run();
