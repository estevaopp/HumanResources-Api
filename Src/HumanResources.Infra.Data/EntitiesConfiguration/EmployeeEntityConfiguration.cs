using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Entities.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumanResources.Infra.Data.EntitiesConfiguration
{
    public class EmployeeEntityConfiguration : IEntityTypeConfiguration<EmployeeEntity>
    {
        public void Configure(EntityTypeBuilder<EmployeeEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.MonthlySalaryFixed).IsRequired().HasPrecision(8,2);

            builder.Property(e => e.MonthlySalaryVariable).IsRequired().HasPrecision(8,2);

            builder.Property(e => e.EmployeeStatus).IsRequired().HasConversion<int>();

            builder.Property(e => e.EmploymentEndDate);

            builder.Property(e => e.EmploymentStartDate).IsRequired();

            builder.Property(e => e.EmployeeSeniority).IsRequired().HasConversion<int>();

            builder.HasOne(e => e.HcmEmployeeRoleEntity).WithMany(e => e.Employees).HasForeignKey(e => e.HcmEmployeeRoleEntityId);
            builder.Property(e => e.HcmEmployeeRoleEntityId).IsRequired();
        }
    }
}