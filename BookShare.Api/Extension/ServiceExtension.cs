using BookShare.Application.Services.Abstraction;
using BookShare.Application.Services.Implementation;
using BookShare.Domain.Model;
using BookShare.Infrastructure.ApplicationContext;
using BookShare.Infrastructure.Repository.Abstraction;
using BookShare.Infrastructure.Repository.Implementation;
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

        public static void ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryBase<BookForSale>, RepositoryBase<BookForSale>>();
            services.AddScoped<IBookForSaleService, BookForSaleService>();
        }
    }
}
