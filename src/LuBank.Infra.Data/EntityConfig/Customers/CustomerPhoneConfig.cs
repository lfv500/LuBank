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
    public class CustomerPhoneConfig : IEntityTypeConfiguration<CustomerPhone>
    {
        public void Configure(EntityTypeBuilder<CustomerPhone> builder)
        {
            //Informando a chave primária
            builder
                .HasKey(e => e.Id);

            //Alterando o nome da chave primária de Id para CustomerId no modelo relacional
            builder
                .Property(e => e.Id)
                .HasColumnName("CustomerPhoneId");

            builder
                .Property(e => e.Number)
                .IsRequired()
                .HasMaxLength(15);

            builder
                .Property(e => e.Ddd)
                .IsRequired();

            builder
                .Property(e => e.Area)
                .IsRequired();
        }
    }
}
