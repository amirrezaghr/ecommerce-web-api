using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Web
{
    public static class ConfigureService
    {
        public static IServiceCollection AddWebServiceCollection(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DefualtConnection"));
            });
            return builder.Services;
        }
    }
}
