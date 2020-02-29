using Fit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fit.Data.Config
{
    public class RankConfig : IEntityTypeConfiguration<Rank>
    {
        public void Configure(EntityTypeBuilder<Rank> builder)
        {
            builder.HasData
            (
                new Rank { Id = 1, Acronym = "Доц.", Name = "Доцент" },
                new Rank { Id = 2, Acronym = "Проф.", Name = "Професор" },
                new Rank { Id = 3, Acronym = "Старш. дослідник", Name = "Старший дослідник" }
            );
        }
    }
}