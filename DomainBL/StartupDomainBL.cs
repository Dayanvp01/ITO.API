using ITO.API.DomainDAL;
using ITO.API.DomainDAL.Interfaces;
using ITO.API.DomainDAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO.API.DomainBL
{
    public class StartupDomainBL
    {
        public static string ConnectionString;
        public static void ConfigureServices(IServiceCollection services, string connectionString)
        {
            ConnectionString = connectionString;
            services.AddScoped<IDependenciaRepository, DependenciaRepository>();
            services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();

            services.AddDbContext<DomainContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

        }
    }
}
