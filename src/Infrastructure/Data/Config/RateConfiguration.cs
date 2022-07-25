using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class RateConfiguration : IEntityTypeConfiguration<Rate>
    {
        public void Configure(EntityTypeBuilder<Rate> builder)
        {
            builder.HasData(
                new Rate { Id = 1, Name = "Picker", RatePerHour = 10 },
                new Rate { Id = 2, Name = "Courier standart", RatePerHour = 8 },
                new Rate { Id = 3, Name = "Courier in company car", RatePerHour = 12 },
                new Rate { Id = 4, Name = "Courier in his car", RatePerHour = 9.5M });
        }
    }
}
