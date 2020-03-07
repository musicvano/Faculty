using Fit.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fit.Data.Config
{
    public class FundingConfig : IEntityTypeConfiguration<Funding>
    {
        public void Configure(EntityTypeBuilder<Funding> builder)
        {
        }
    }
}