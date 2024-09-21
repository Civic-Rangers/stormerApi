
using Contracts;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;
using Service;
using Microsoft.OpenApi.Models;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
//using Entities.ConfigurationModels;


namespace StormSurge.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {
                //  options.AutomaticAuthentication = false;
                //  options.AuthenticationDisplayName = "Windows";
                //  options.ForwardClientCertificate = false;
                //  options.ForwardWindowsAuthentication = false;
            });


        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(options =>
                           options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        public static void ConfigureSwagger(this IServiceCollection services) =>
        services.AddSwaggerGen(s =>
        {
            s.SwaggerDoc("v1", new OpenApiInfo { Title = "StormSurge", Version = "v1" });
        });

        

    }

}
