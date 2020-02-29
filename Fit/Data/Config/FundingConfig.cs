using Fit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fit.Data.Config
{
    public class FundingConfig : IEntityTypeConfiguration<Funding>
    {
        public void Configure(EntityTypeBuilder<Funding> builder)
        {
            builder.HasData
            (
                new Funding { Id = 1, Acronym = "Б", Name = "Бюджет" },
                new Funding { Id = 2, Acronym = "К", Name = "Контракт" }
            );
        }
    }
}