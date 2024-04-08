using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using J20240408.EntidadesDeNegocio;
namespace J20240408.AccesoADatos
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddDALDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("conn")));
            services.AddScoped<PersonaJDAL>();

            return services;
        }
    }
}
