using LuBank.Domain.Interfaces.Repository;
using LuBank.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LuBank.Infra.IOC
{
    public static class InversionOfControl
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //Infra Data
            services.AddTransient<ICustomerRepository, CustomerRepository>();
        }
    }
}
