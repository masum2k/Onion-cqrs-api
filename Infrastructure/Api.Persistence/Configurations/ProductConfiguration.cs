using Api.Domain.Entitites;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Persistence.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Product product1 = new Product
            {
                Id = 1,
                Title = "İnanılmaz Plastik Sandalye",
                Description = "Uzun ömürlü ve ergonomik ürün açıklaması",
                BrandId = 1,
                Discount = 3.5m,
                Price = 150.99m,
                CreatedDate = new DateTime(2025, 1, 1),
                IsDeleted = false
            };
            Product product2 = new Product
            {
                Id = 2,
                Title = "Modern Masa Lambası",
                Description = "Göz yormayan LED ışık teknolojisi",
                BrandId = 3,
                Discount = 5.2m,
                Price = 89.99m,
                CreatedDate = new DateTime(2025, 1, 1),
                IsDeleted = false
            };
            builder.HasData(product1, product2);
        }

    }
}
