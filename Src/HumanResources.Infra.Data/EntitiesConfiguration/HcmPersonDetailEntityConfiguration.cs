using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Entities.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResources.Infra.Data.EntitiesConfiguration
{
    public class HcmPersonDetailEntityConfiguration : IEntityTypeConfiguration<HcmPersonDetailEntity>
    {
        public void Configure(EntityTypeBuilder<HcmPersonDetailEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(50);

            builder.Property(e => e.MiddleName).IsRequired().HasMaxLength(50);

            builder.Property(e => e.LastName).IsRequired().HasMaxLength(50);

            builder.Property(e => e.Email).IsRequired().HasMaxLength(50);

            builder.Property(e => e.CellPhoneNumber).IsRequired().HasMaxLength(20);

            builder.Property(e => e.Cpf).IsRequired().HasMaxLength(11);

            builder.Property(e => e.Birthdate).IsRequired();

            builder.Property(e => e.Gender).IsRequired().HasConversion<int>();

            builder.HasOne(e => e.EmployeeEntity).WithOne(e => e.HcmPersonDetailEntity).HasForeignKey<HcmPersonDetailEntity>(e => e.EmployeeEntityId);
            builder.Property(e => e.EmployeeEntityId).IsRequired();
        }
    }
}