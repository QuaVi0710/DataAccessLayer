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
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    Id = Guid.Parse("C1E0B9D2-A3F4-4E5D-B8C7-6D9E8F0A1B2C"),
                    Name = "Microsoft",
                    Address = "Redmond, WA",
                    Country = "USA"
                },
                new Company
                {
                    Id = Guid.Parse("D1A1B2C3-D4E5-6789-ABCD-EF0123456789"),
                    Name = "Google",
                    Address = "Mountain View, CA",
                    Country = "USA"
                }
            );
        }
    }
}
