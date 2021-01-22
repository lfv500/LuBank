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
    public class CustomerAddressConfig : IEntityTypeConfiguration<CustomerAddress>
    {
        public void Configure(EntityTypeBuilder<CustomerAddress> builder)
        {
            //Informando a chave primária
            builder
                .HasKey(e => e.Id);

            //Alterando o nome da chave primária de Id para CustomerAddressId no modelo relacional
            builder
                .Property(e => e.Id)
                .HasColumnName("CustomerAddressId");

            builder
                .Property(e => e.Number)
                .IsRequired();

            builder
                .Property(e => e.Street)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(e => e.ZipCode)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(e => e.Province)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(e => e.Neighborhood)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(e => e.City)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
