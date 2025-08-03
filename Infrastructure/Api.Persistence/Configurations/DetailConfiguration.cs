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
    internal class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Detail detail1 = new()
            {
                Id = 1,
                Title = "Dayanıklı Malzeme",
                Description = "Suya ve darbeye karşı dirençli yapı",
                CategoryId = 1,
                CreatedDate = new DateTime(2025, 1, 1),
                IsDeleted = false,
            };
            Detail detail2 = new()
            {
                Id = 2,
                Title = "Modern Tasarım",
                Description = "Şık ve minimal estetik çizgiler",
                CategoryId = 3,
                CreatedDate = new DateTime(2025, 1, 1),
                IsDeleted = true,
            };
            Detail detail3 = new()
            {
                Id = 3,
                Title = "Geniş Depolama",
                Description = "1 TB SSD ile yüksek hız ve kapasite",
                CategoryId = 4,
                CreatedDate = new DateTime(2025, 1, 1),
                IsDeleted = false,
            };
            builder.HasData(detail1, detail2, detail3);
        }

    }
}
