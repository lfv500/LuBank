using LuBank.Domain.Interfaces.Repository;
using LuBank.Domain.Interfaces.Services;
using LuBank.Domain.Services;
using LuBank.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LuBank.Infra.IOC
{
    public static class InversionOfControl
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //Domain services
            services.AddTransient<ICustomerService, CustomerService>();

            //Infra Data
            services.AddTransient<ICustomerRepository, CustomerRepository>();
        }
    }
}
