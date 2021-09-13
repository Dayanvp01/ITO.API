using ITO.API.DomainBL;
using ITO.API.DomainBL.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO.API.DomainServices
{
    public class StartupDomainServices
    {
        public static void ConfigureServices(IServiceCollection services, string connectionString)
        {
            services.AddScoped<IDependenciaBL, DependenciaBL>();
            services.AddScoped<IEmpleadoBL, EmpleadoBL>();
            //Dependencias internas de la capas de negocio 
            StartupDomainBL.ConfigureServices(services, connectionString);
        }
    }
}
