using AutoMapper;
using LuBank.Application.AppService;
using LuBank.Application.AutoMapper;
using LuBank.Application.Interfaces.AppService;
using LuBank.Domain.Interfaces.Repository;
using LuBank.Domain.Interfaces.Services;
using LuBank.Domain.Services;
using LuBank.Infra.Data.Context;
using LuBank.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LuBank.Infra.IOC
{
    public static class InversionOfControl
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //App Services
            services.AddScoped<ICustomerAppService, CustomerAppService>();

            //Domain services
            services.AddScoped<ICustomerService, CustomerService>();

            //Infra Data
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<LuBankDataContext>();

            //Registrando AutoMapper
            var mapperConfig = AutoMapperConfig.RegisterMappings();
            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton<IMapper>(mapper);
        }
    }
}
