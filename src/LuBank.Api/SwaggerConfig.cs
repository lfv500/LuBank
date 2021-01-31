using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuBank.Api
{
    /// <summary>
    /// Classe de extensão de configuração do Swagger
    /// </summary>
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;
            var version = "V" + thisAssembly.GetName().Version.ToString();

            return services.AddSwaggerGen(e=>
            {
                e.SwaggerDoc("V1",
                    new OpenApiInfo
                    {
                        Title = "LuBank API de Integração",
                        Version = "V1",
                        Description = $"(Build Version: {version})"
                    });

                e.AddSecurityDefinition("authToken", new OpenApiSecurityScheme 
                {
                    In = ParameterLocation.Header,
                    Name = "authToken",
                    Description = "API Authentication Token"
                });
            });
        }

        public static IApplicationBuilder UseSwaggerAndSetConfig(this IApplicationBuilder app)
        {
            return app.UseSwagger()
                .UseSwaggerUI(e =>
                {
                    e.SwaggerEndpoint("/swagger/V1/swagger.json", "LuBank API de Integração");
                    e.RoutePrefix = string.Empty;
                    e.SupportedSubmitMethods(SubmitMethod.Get, SubmitMethod.Head, SubmitMethod.Post, SubmitMethod.Delete, SubmitMethod.Put);
                });
        }
    }
}
