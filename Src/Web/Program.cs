using Infrastructure;
using Infrastructure.Persistence;
using Infrastructure.Persistence.SeedData;
using Microsoft.EntityFrameworkCore;
using Web;

var builder = WebApplication.CreateBuilder(args);


//configurations
builder.Services.AddInfrastactureServices(builder.Configuration);
builder.AddWebConfigureService();
//build
var app = builder.Build();
await app.AddWebAppServiceAsync().ConfigureAwait(false);
