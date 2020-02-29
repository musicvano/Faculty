using Fit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fit.Data.Config
{
    public class FacultyConfig : IEntityTypeConfiguration<Faculty>
    {
        public void Configure(EntityTypeBuilder<Faculty> builder)
        {
            builder.HasData
            (
                new Faculty { Id = 1, Acronym = "БФ", Name = "Будівельний факультет" },
                new Faculty { Id = 2, Acronym = "ГЕФ", Name = "Геолого-екологічний факультет" },
                new Faculty { Id = 3, Acronym = "ГМФ", Name = "Гірничо-металургійний факультет" },
                new Faculty { Id = 4, Acronym = "ЕТФ", Name = "Електротехнічний факультет" },
                new Faculty { Id = 5, Acronym = "ММФ", Name = "Механіко-машинобудівний факультет" },
                new Faculty { Id = 6, Acronym = "ТФ", Name = "Транспортний факультет" },
                new Faculty { Id = 7, Acronym = "ФЕУБ", Name = "Факультет економіки та управління бізнесом" },
                new Faculty { Id = 8, Acronym = "ФІТФ", Name = "Факультет інформаційних технологій" }
            );
        }
    }
}