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
    public class ModelToViewModelMappingConfig : Profile
    {
        public ModelToViewModelMappingConfig()
        {
            //Configurando o mapeamento entre as classes de Model => ViewModel
            CreateMap<Customer, CustomerViewModel>();
            CreateMap<CustomerAddress, CustomerAddressViewModel>();
            CreateMap<CustomerDocument, CustomerDocumentViewModel>();
            CreateMap<CustomerPhone, CustomerPhoneViewModel>();
            CreateMap<Domain.Model.Enums.Customer.CustomerDocumentType, Application.Enum.Customers.CustomerDocumentType>();
        }
    }
}
