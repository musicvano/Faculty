using Fit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fit.Data.Config
{
    public class DegreeConfig : IEntityTypeConfiguration<Degree>
    {
        public void Configure(EntityTypeBuilder<Degree> builder)
        {
            builder.HasData
            (
                new Degree { Id = 1, Acronym = "Канд. арх.", Name = "Кандидат архітектури" },
                new Degree { Id = 2, Acronym = "Канд. біол. наук", Name = "Кандидат біологічних наук" },
                new Degree { Id = 3, Acronym = "Канд. вет. наук", Name = "Кандидат ветеринарних наук" },
                new Degree { Id = 4, Acronym = "Канд. військ. наук", Name = "Кандидат військових наук" },
                new Degree { Id = 5, Acronym = "Канд. географ. наук", Name = "Кандидат географічних наук" },
                new Degree { Id = 6, Acronym = "Канд. геолог. наук", Name = "Кандидат геологічних наук" },
                new Degree { Id = 7, Acronym = "Канд. держ. упр.", Name = "Кандидат наук з державного управління" },
                new Degree { Id = 8, Acronym = "Канд. екон. наук", Name = "Кандидат економічних наук" },
                new Degree { Id = 9, Acronym = "Канд. іст. наук", Name = "Кандидат історичних наук" },
                new Degree { Id = 10, Acronym = "Канд. культ.", Name = "Кандидат культурології" },
                new Degree { Id = 11, Acronym = "Канд. мед. наук", Name = "Кандидат медичних наук" },
                new Degree { Id = 12, Acronym = "Канд. мист.", Name = "Кандидат мистецтвознавства" },
                new Degree { Id = 13, Acronym = "Канд. пед. наук", Name = "Кандидат педагогічних наук" },
                new Degree { Id = 14, Acronym = "Канд. політ. наук", Name = "Кандидат політичних наук" },
                new Degree { Id = 15, Acronym = "Канд. психол. наук", Name = "Кандидат психологічних наук" },
                new Degree { Id = 16, Acronym = "Канд. с.-г. наук", Name = "Кандидат сільськогосподарських наук" },
                new Degree { Id = 17, Acronym = "Канд. соц. ком.", Name = "Кандидат наук із соціальних комунікацій" },
                new Degree { Id = 18, Acronym = "Канд. соціол. наук", Name = "Кандидат соціологічних наук" },
                new Degree { Id = 19, Acronym = "Канд. техн. наук", Name = "Кандидат технічних наук" },
                new Degree { Id = 20, Acronym = "Канд. фіз.-мат. наук", Name = "Кандидат фізико-математичних наук" },
                new Degree { Id = 21, Acronym = "Канд. фармац. наук", Name = "Кандидат фармацевтичних наук" },
                new Degree { Id = 22, Acronym = "Канд. фіз. виховання і спорту", Name = "Кандидат наук з фізичного виховання і спорту" },
                new Degree { Id = 23, Acronym = "Канд. філол. наук", Name = "Кандидат філологічних наук" },
                new Degree { Id = 24, Acronym = "Канд. філос. наук", Name = "Кандидат філософських наук" },
                new Degree { Id = 25, Acronym = "Канд. хім. наук", Name = "Кандидат хімічних наук" },
                new Degree { Id = 26, Acronym = "Канд. юрид. наук", Name = "Кандидат юридичних наук" },
                new Degree { Id = 27, Acronym = "Д-р арх.", Name = "Доктор архітектури" },
                new Degree { Id = 28, Acronym = "Д-р біол. наук", Name = "Доктор біологічних наук" },
                new Degree { Id = 29, Acronym = "Д-р вет. наук", Name = "Доктор ветеринарних наук" },
                new Degree { Id = 30, Acronym = "Д-р військ. наук", Name = "Доктор військових наук" },
                new Degree { Id = 31, Acronym = "Д-р географ. наук", Name = "Доктор географічних наук" },
                new Degree { Id = 32, Acronym = "Д-р геолог. наук", Name = "Доктор геологічних наук" },
                new Degree { Id = 33, Acronym = "Д-р держ. упр.", Name = "Доктор наук з державного управління" },
                new Degree { Id = 34, Acronym = "Д-р екон. наук", Name = "Доктор економічних наук" },
                new Degree { Id = 35, Acronym = "Д-р іст. наук", Name = "Доктор історичних наук" },
                new Degree { Id = 36, Acronym = "Д-р культ.", Name = "Доктор культурології" },
                new Degree { Id = 37, Acronym = "Д-р мед. наук", Name = "Доктор медичних наук" },
                new Degree { Id = 38, Acronym = "Д-р мист.", Name = "Доктор мистецтвознавства" },
                new Degree { Id = 39, Acronym = "Д-р пед. наук", Name = "Доктор педагогічних наук" },
                new Degree { Id = 40, Acronym = "Д-р політ. наук", Name = "Доктор політичних наук" },
                new Degree { Id = 41, Acronym = "Д-р психол. наук", Name = "Доктор психологічних наук" },
                new Degree { Id = 42, Acronym = "Д-р с.-г. наук", Name = "Доктор сільськогосподарських наук" },
                new Degree { Id = 43, Acronym = "Д-р соц. ком.", Name = "Доктор наук із соціальних комунікацій" },
                new Degree { Id = 44, Acronym = "Д-р соціол. наук", Name = "Доктор соціологічних наук" },
                new Degree { Id = 45, Acronym = "Д-р техн. наук", Name = "Доктор технічних наук" },
                new Degree { Id = 46, Acronym = "Д-р фіз.-мат. наук", Name = "Доктор фізико-математичних наук" },
                new Degree { Id = 47, Acronym = "Д-р фармац. наук", Name = "Доктор фармацевтичних наук" },
                new Degree { Id = 48, Acronym = "Д-р фіз. виховання і спорту", Name = "Доктор наук з фізичного виховання і спорту" },
                new Degree { Id = 49, Acronym = "Д-р філол. наук", Name = "Доктор філологічних наук" },
                new Degree { Id = 50, Acronym = "Д-р філос. наук", Name = "Доктор філософських наук" },
                new Degree { Id = 51, Acronym = "Д-р хім. наук", Name = "Доктор хімічних наук" },
                new Degree { Id = 52, Acronym = "Д-р юрид. наук", Name = "Доктор юридичних наук" }
            );
        }
    }
}