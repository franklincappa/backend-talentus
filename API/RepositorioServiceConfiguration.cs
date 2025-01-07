using Core.Interfaces;
using Core.Services;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Authorization;

namespace API
{
    public static class RepositorioServiceConfiguration
    {
        public static void ConfigurarRepositorios(this IServiceCollection servicios)
        {
            //Repository
            servicios.AddScoped<IPersonaRepository, PersonaRepository>();
            servicios.AddScoped<IUbigeoRepository, UbigeoRepository>();
            servicios.AddScoped<ITablaRepository, TablaRepository>();

            //Services
            servicios.AddScoped<TablaService>();
            servicios.AddScoped<UbigeoService>();
            servicios.AddScoped<PersonaService>();
        }
    }
}

