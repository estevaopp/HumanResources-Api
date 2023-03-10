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
        }
    }
}