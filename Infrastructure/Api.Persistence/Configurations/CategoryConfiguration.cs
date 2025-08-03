using Api.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Persistence.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                Id = 1,
                Name = "Electrik",
                Priority = 1,
                ParentId = 0,
                IsDeleted = false,
                CreatedDate = new DateTime(2025, 1, 1)
            };
            Category category2 = new()
            {
                Id = 2,
                Name = "Moda",
                Priority = 2,
                ParentId = 0,
                IsDeleted = false,
                CreatedDate = new DateTime(2025, 1, 1)
            };
            Category parent = new()
            {
                Id = 3,
                Name = "Bilgisayar",
                Priority = 1,
                ParentId = 1,
                IsDeleted = false,
                CreatedDate = new DateTime(2025, 1, 1)
            };
            Category parent2 = new()
            {
                Id = 4,
                Name = "Kadın",
                Priority = 1,
                ParentId = 2,
                IsDeleted = false,
                CreatedDate = new DateTime(2025, 1, 1)
            };
            builder.HasData(
                category1,
                category2,
                parent,
                parent2
            );

        }
    }
}
