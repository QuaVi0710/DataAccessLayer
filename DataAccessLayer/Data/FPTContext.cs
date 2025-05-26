using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects.Models;
using DataAccessLayer.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data
{
    public class FPTContext : DbContext
    {
        public FPTContext(DbContextOptions<FPTContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }
    }
}
