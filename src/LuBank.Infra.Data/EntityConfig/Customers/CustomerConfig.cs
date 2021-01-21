using LuBank.Domain.Model.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Infra.Data.EntityConfig.Customers
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            //Informando a chave primária
            builder
                .HasKey(e => e.Id);

            //Alterando o nome da chave primária de Id para CustomerId no modelo relacional
            builder
                .Property(e => e.Id)
                .HasColumnName("CustomerId");

            builder
                .Property(e => e.Name)
                //Alterando o tamanho do campo para uma string de no max 255 chars
                .HasMaxLength(255)
                //Configurando como Not NUll
                .IsRequired();
        }
    }
}
