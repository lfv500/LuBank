using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Application.AutoMapper
{
    public static class AutoMapperConfig
    {
        /// <summary>
        /// Configurações de AutoMapper
        /// </summary>
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(e =>
            {
                e.AddProfile(new ModelToViewModelMappingConfig());
                e.AddProfile(new ViewModelToModelMappingConfig());
            });
        }
    }
}
