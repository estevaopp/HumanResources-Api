using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Entities.Employees;
using Microsoft.EntityFrameworkCore;

namespace HumanResources.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<EmployeeEntity> EmployeeEntities { get; set; }
        public DbSet<HcmEmployeeRoleEntity> HcmEmployeeRoleEntities { get; set; }
        public DbSet<HcmPersonDetailEntity> HcmPersonDetailEntities { get; set; }
    }
}