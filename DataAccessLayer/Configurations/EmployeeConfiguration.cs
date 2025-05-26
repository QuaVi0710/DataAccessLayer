using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = Guid.Parse("A1B2C3D4-0000-0000-0000-000000000001"),
                    Name = "John Doe",
                    Age = 30,
                    Position = "Software Developer",
                    CompanyId = Guid.Parse("C1E0B9D2-A3F4-4E5D-B8C7-6D9E8F0A1B2C")
                },
                new Employee
                {
                    Id = Guid.Parse("A1B2C3D4-0000-0000-0000-000000000002"),
                    Name = "Jane Smith",
                    Age = 28,
                    Position = "Project Manager",
                    CompanyId = Guid.Parse("C1E0B9D2-A3F4-4E5D-B8C7-6D9E8F0A1B2C")
                }
            );
        }
    }
}
