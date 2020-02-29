using Fit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Fit.Data.Config
{
    public class PositionConfig : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasData
            (
                new Position { Id = 1, Acronym = "Асист.", Name = "Асистент" },
                new Position { Id = 2, Acronym = "Викл.", Name = "Викладач" },
                new Position { Id = 3, Acronym = "Старш. викл.", Name = "Старший викладач" },
                new Position { Id = 4, Acronym = "Доц.", Name = "Доцент" },
                new Position { Id = 5, Acronym = "Проф.", Name = "Професор" },
                new Position { Id = 6, Acronym = "В. о. завкаф.", Name = "В. о. завідувача кафедри" },
                new Position { Id = 7, Acronym = "Завкаф.", Name = "Завідувач кафедри" }
            );
        }
    }
}