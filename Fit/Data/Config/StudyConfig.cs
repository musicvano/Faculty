using Fit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fit.Data.Config
{
    public class StudyConfig : IEntityTypeConfiguration<Study>
    {
        public void Configure(EntityTypeBuilder<Study> builder)
        {
            builder.HasData
            (
                new Study { Id = 1, Acronym = "Д", Name = "Денна форма" },
                new Study { Id = 2, Acronym = "З", Name = "Заочна форма" }
            );
        }
    }
}