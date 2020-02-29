using Fit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fit.Data.Config
{
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData
            (
                new City { Id = 1, Name = "Київ" },
                new City { Id = 2, Name = "Харків" },
                new City { Id = 3, Name = "Дніпро" },
                new City { Id = 4, Name = "Кривий Ріг" },
                new City { Id = 5, Name = "Львів" }
            );
        }
    }
}