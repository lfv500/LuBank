using AutoMapper;
using LuBank.Application.ViewModel.Customers;
using LuBank.Domain.Model.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Application.AutoMapper
{
    public class ViewModelToModelMappingConfig : Profile
    {
        public ViewModelToModelMappingConfig()
        {
            //Configurando o mapeamento entre as classes de ViewModel => Model
            CreateMap<CustomerViewModel, Customer>();
            CreateMap<CustomerAddressViewModel, CustomerAddress>();
            CreateMap<CustomerDocumentViewModel, CustomerDocument>();
            CreateMap<CustomerPhoneViewModel, CustomerPhone>();
            CreateMap<Application.Enum.Customers.CustomerDocumentType, Domain.Model.Enums.Customer.CustomerDocumentType>();
        }
    }
}
