using Infrastructure;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddInfrastactureServices(builder.Configuration);
builder.AddWebServiceCollection();

var app = builder.Build();
var loggerFactory = app.Services.GetRequiredService<ILoggerFactory>();
//auto migrations
try
{
    var context = app.Services.GetRequiredService<ApplicationDbContext>();
    await context.Database.MigrateAsync();
}
catch(Exception e)
{
    var logger = loggerFactory.CreateLogger<Program>();
    logger.LogError(e, "error exeptions for migrations");
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
