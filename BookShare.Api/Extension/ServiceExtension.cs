using BookShare.Application.Services.Abstraction;
using BookShare.Application.Services.Implementation;
using BookShare.Domain.Model;
using BookShare.Infrastructure.ApplicationContext;
using BookShare.Infrastructure.Repository.Abstraction;
using BookShare.Infrastructure.Repository.Implementation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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

        public static void ConfigureRepositoryBase(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped <IDeliveryRepository, DeliveryRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }

        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<ITransporterService, TransporterService>();
            services.AddScoped<IDeliveryService, DeliveryService>();
            services.AddScoped<IBookForSaleService, BookForSaleService>();
            services.AddScoped<IUserService, UserService>();
            


        }
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>(opt =>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = true;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 8;
                opt.User.RequireUniqueEmail = true;
                opt.SignIn.RequireConfirmedEmail = true;
            })
                .AddEntityFrameworkStores<BookShareContext>()
                .AddDefaultTokenProviders();
        }
        public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection("JwtSettings");
            var secretKey = Environment.GetEnvironmentVariable("SECRET");
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings["validIssuer"],
                    ValidAudience = jwtSettings["validAudience"],
                    IssuerSigningKey = new
                    SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                };
            });
        }
    }
}
