using Fit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fit.Data.Config
{
    public class RegionConfig : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasData
            (
                new Region { Id = 1, Acronym = "АРК", Name = "Автономна Республіка Крим" },
                new Region { Id = 2, Acronym = "Вінницька обл.", Name = "Вінницька область" },
                new Region { Id = 3, Acronym = "Волинська обл.", Name = "Волинська область" },
                new Region { Id = 4, Acronym = "Дніпропетровська обл.", Name = "Дніпропетровська область" },
                new Region { Id = 5, Acronym = "Донецька обл.", Name = "Донецька область" },
                new Region { Id = 6, Acronym = "Житомирська обл.", Name = "Житомирська область" },
                new Region { Id = 7, Acronym = "Закарпатська обл.", Name = "Закарпатська область" },
                new Region { Id = 8, Acronym = "Запорізька обл.", Name = "Запорізька область" },
                new Region { Id = 9, Acronym = "Івано-Франківська обл.", Name = "Івано-Франківська область" },
                new Region { Id = 10, Acronym = "Київська обл.", Name = "Київська область" },
                new Region { Id = 11, Acronym = "Кіровоградська обл.", Name = "Кіровоградська область" },
                new Region { Id = 12, Acronym = "Луганська обл.", Name = "Луганська область" },
                new Region { Id = 13, Acronym = "Львівська обл.", Name = "Львівська область" },
                new Region { Id = 14, Acronym = "Миколаївська обл.", Name = "Миколаївська область" },
                new Region { Id = 15, Acronym = "Одеська обл.", Name = "Одеська область" },
                new Region { Id = 16, Acronym = "Полтавська обл.", Name = "Полтавська область" },
                new Region { Id = 17, Acronym = "Рівненська обл.", Name = "Рівненська область" },
                new Region { Id = 18, Acronym = "Сумська обл.", Name = "Сумська область" },
                new Region { Id = 19, Acronym = "Тернопільська обл.", Name = "Тернопільська область" },
                new Region { Id = 20, Acronym = "Харківська обл.", Name = "Харківська область" },
                new Region { Id = 21, Acronym = "Херсонська обл.", Name = "Херсонська область" },
                new Region { Id = 22, Acronym = "Хмельницька обл.", Name = "Хмельницька область" },
                new Region { Id = 23, Acronym = "Черкаська обл.", Name = "Черкаська область" },
                new Region { Id = 24, Acronym = "Чернівецька обл.", Name = "Чернівецька область" },
                new Region { Id = 25, Acronym = "Чернігівська обл.", Name = "Чернігівська область" }
            );
        }
    }
}