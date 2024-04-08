using J20240408.AccesoADatos;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace J20240408.LogicaDeNegocio
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddBLDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDALDependecies(configuration);
            services.AddScoped<PersonaJBL>();
            return services;
        }
    }
}
