using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Store.G04.Services.Mapping.Products;

namespace Store.G04.Services
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddAutoMapper(M => M.AddProfile(new ProductProfile(configuration)));
            return services;
        }
    }
}
