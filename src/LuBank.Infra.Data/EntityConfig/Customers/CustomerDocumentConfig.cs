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
    public class CustomerDocumentConfig : IEntityTypeConfiguration<CustomerDocument>
    {
        public void Configure(EntityTypeBuilder<CustomerDocument> builder)
        {
            //Informando a chave primária
            builder
                .HasKey(e => e.Id);

            //Alterando o nome da chave primária de Id para CustomerDocumentId no modelo relacional
            builder
                .Property(e => e.Id)
                .HasColumnName("CustomerDocumentId");

            builder
                .Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(e => e.Type)
                .IsRequired();
        }
    }
}
