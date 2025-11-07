using Data_Access_Layer_DL_.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Business_Layer_BL_.Extensions.F_ServiceRegExtensions
{
    public static class ServiceRegExtensions
    {

        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Register AppDbContext
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Connection")));
           
       

            return services;
        }

    }
}
