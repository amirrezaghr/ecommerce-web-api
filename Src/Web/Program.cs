using Application;
using Infrastructure;
using Web;

var builder = WebApplication.CreateBuilder(args);


//configurations
builder.Services.AddApplicationServices();
builder.Services.AddInfrastactureServices(builder.Configuration);
builder.AddWebConfigureService();
//build
var app = builder.Build();
await app.AddWebAppServiceAsync().ConfigureAwait(false);
