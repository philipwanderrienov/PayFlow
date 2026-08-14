using Microsoft.EntityFrameworkCore;
using PayFlow.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
builder.Services.AddHealthChecks();
builder.Services.AddDbContext<PayFlowDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PayFlow")));

var app = builder.Build();
if (app.Environment.IsDevelopment()) app.MapOpenApi();
app.UseHttpsRedirection();
app.MapHealthChecks("/health");
app.MapGet("/api", () => Results.Ok(new { service = "PayFlow.Api", status = "running" }));
app.Run();

public partial class Program;
