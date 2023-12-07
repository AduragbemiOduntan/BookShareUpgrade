using BookShare.Infrastructure.ApplicationContext;
using Microsoft.EntityFrameworkCore;

namespace BookShare.Api.Extension
{
    public static class ServiceExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookShareContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("Default"));
            });


        }
    }
}
