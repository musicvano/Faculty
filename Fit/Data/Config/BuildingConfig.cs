using Fit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fit.Data.Config
{
    public class BuildingConfig : IEntityTypeConfiguration<Building>
    {
        public void Configure(EntityTypeBuilder<Building> builder)
        {
            builder.HasData
            (
                new Building { Id = 1, Name = "Центральний корпус" },
                new Building { Id = 2, Name = "Будівельний корпус" },
                new Building { Id = 3, Name = "Гірничий корпус" },
                new Building { Id = 4, Name = "Трампарк-корпус" }
            );
        }
    }
}