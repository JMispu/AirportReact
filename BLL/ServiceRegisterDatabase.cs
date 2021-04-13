using DAL.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public static class ServiceRegisterDatabase
    {
        public static IServiceCollection RegisterDatabase(this IServiceCollection services, string connection)
        {
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.RegisterBaseContext(connection);
            return services;
        }
    }
}
