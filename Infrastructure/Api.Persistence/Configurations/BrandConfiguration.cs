using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Domain.Entitites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Bogus;

namespace Api.Persistence.Configurations
{
    internal class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(256);

            Brand brand1 = new()
            {
                Id = 1,
                Name = "TechNova",
                CreatedDate = new DateTime(2025, 1, 1),
                IsDeleted = false
            };
            Brand brand2 = new()
            {
                Id = 2,
                Name = "ModaLine",
                CreatedDate = new DateTime(2025, 1, 1),
                IsDeleted = false
            };
            Brand brand3 = new()
            {
                Id = 3,
                Name = "HomeEssence",
                CreatedDate = new DateTime(2025, 1, 1),
                IsDeleted = true
            };
            builder.HasData(brand1, brand2, brand3);
        }



    }
}
