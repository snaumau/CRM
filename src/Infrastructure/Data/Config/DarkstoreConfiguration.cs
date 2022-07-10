using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class DarkstoreConfiguration : IEntityTypeConfiguration<Darkstore>
    {
        public void Configure(EntityTypeBuilder<Darkstore> builder)
        {
            builder.HasData(
                new Darkstore { DarkstoreId = 1, Name = "Brooklyn" },
                new Darkstore { DarkstoreId = 2, Name = "The Bronx" },
                new Darkstore { DarkstoreId = 3, Name = "Queens" });
        }
    }
}
