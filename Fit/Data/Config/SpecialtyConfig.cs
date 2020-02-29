using Fit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fit.Data.Config
{
    public class SpecialtyConfig : IEntityTypeConfiguration<Specialty>
    {
        public void Configure(EntityTypeBuilder<Specialty> builder)
        {
            builder.HasData
            (
                new Specialty { Id = 1, Code = "015", Name = "Професійна освіта" },
                new Specialty { Id = 2, Code = "121", Name = "Автоматизація та комп’ютерно-інтегровані технології" },
                new Specialty { Id = 3, Code = "122", Name = "Інженерія програмного забезпечення" },
                new Specialty { Id = 4, Code = "123", Name = "Комп’ютерні науки" },
                new Specialty { Id = 5, Code = "151", Name = "Комп’ютерна інженерія" }
            );
        }
    }
}