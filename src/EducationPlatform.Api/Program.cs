using EducationPlatform.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("EducationPlatform");
if (string.IsNullOrWhiteSpace(connectionString))
{
    throw new InvalidOperationException(
        "Missing connection string 'EducationPlatform'. Configure ConnectionStrings__EducationPlatform.");
}

builder.Services.AddDbContext<PlatformDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddProblemDetails();
builder.Services.AddHealthChecks();

var app = builder.Build();

app.UseExceptionHandler();
app.MapHealthChecks("/health");
app.MapGet("/", () => Results.Ok(new
{
    service = "Glodin United Education Platform API",
    status = "development-scaffold",
    message = "Authentication, authorization, and tenant isolation are not implemented."
}));

app.Run();

public partial class Program;
