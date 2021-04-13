using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public static class ServiceRegisterBaseContext
    {
        public static IServiceCollection RegisterBaseContext(this IServiceCollection services, string connection)
        {
            services.AddScoped(typeof(DbContext), typeof(AirportContext));
            services.AddDbContext<AirportContext>(options => options.UseLazyLoadingProxies().UseSqlServer(connection));
            return services;
        }
    }
}
