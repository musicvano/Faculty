using Fit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fit.Data.Config
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData
            (
                new
                {
                    Id = 1,
                    Acronym = "Кафедра ПЦМБ",
                    Name = "Кафедра промислового, цивільного і міського будівництва",
                    FacultyId = 1
                },
                new
                {
                    Id = 2,
                    Acronym = "Кафедра ТБВМВ",
                    Name = "Кафедра технології будівельних виробів, матеріалів та конструкцій",
                    FacultyId = 1
                },
                new
                {
                    Id = 3,
                    Acronym = "Кафедра ТВВ",
                    Name = "Кафедра теплогазoводопостачання, водовідведення і вентиляції",
                    FacultyId = 1
                },
                new
                {
                    Id = 4,
                    Acronym = "Кафедра ГПМ",
                    Name = "Кафедра геології і прикладної мінералогії",
                    FacultyId = 2
                },
                new
                {
                    Id = 5,
                    Acronym = "Кафедра екол.",
                    Name = "Кафедра екології",
                    FacultyId = 2
                },
                new
                {
                    Id = 6,
                    Acronym = "Кафедра геодез.",
                    Name = "Кафедра геодезії",
                    FacultyId = 2
                },
                new
                {
                    Id = 7,
                    Acronym = "Кафедра ПРРКК",
                    Name = "Кафедра підземної розробки родовищ корисних копалин",
                    FacultyId = 3
                },
                new
                {
                    Id = 8,
                    Acronym = "Кафедра ВГР",
                    Name = "Кафедра відкритих гірничих робіт",
                    FacultyId = 3
                },
                new
                {
                    Id = 9,
                    Acronym = "Кафедра маркшейдерії",
                    Name = "Кафедра маркшейдерії",
                    FacultyId = 3
                },
                new
                {
                    Id = 10,
                    Acronym = "Кафедра ОПЦБ",
                    Name = "Кафедра охорони праці та цивільної безпеки",
                    FacultyId = 3
                },
                new
                {
                    Id = 11,
                    Acronym = "Кафедра БГ",
                    Name = "Кафедра будівельних геотехнологій",
                    FacultyId = 3
                },
                new
                {
                    Id = 12,
                    Acronym = "Кафедра ЗККХ",
                    Name = "Кафедра збагачення корисних копалин і хімії",
                    FacultyId = 3
                },
                new
                {
                    Id = 13,
                    Acronym = "Кафедра МЧМЛВ",
                    Name = "Кафедра металургії чорних металів і ливарного виробництва",
                    FacultyId = 3
                },
                new
                {
                    Id = 14,
                    Acronym = "Кафедра АЕСПТ",
                    Name = "Кафедра автоматизованих електромеханічних систем в промисловості та транспорті",
                    FacultyId = 4
                },
                new
                {
                    Id = 15,
                    Acronym = "Кафедра ЕЕМ",
                    Name = "Кафедра електропостачання та енергетичного менеджменту",
                    FacultyId = 4
                },
                new
                {
                    Id = 16,
                    Acronym = "Кафедра ЕМ",
                    Name = "Кафедра електромеханіки",
                    FacultyId = 4
                },
                new
                {
                    Id = 17,
                    Acronym = "Кафедра ТЕ",
                    Name = "Кафедра теплоенергетики",
                    FacultyId = 4
                },
                new
                {
                    Id = 18,
                    Acronym = "Кафедра фізики",
                    Name = "Кафедра фізики",
                    FacultyId = 4
                },
                new
                {
                    Id = 19,
                    Acronym = "Кафедра ПМЗД",
                    Name = "Кафедра прикладної механіки та загальноінженерних дисциплін",
                    FacultyId = 5
                },
                new
                {
                    Id = 20,
                    Acronym = "Кафедра ТМ",
                    Name = "Кафедра технології машинобудування",
                    FacultyId = 5
                },
                new
                {
                    Id = 21,
                    Acronym = "Кафедра ГМО",
                    Name = "Кафедра гірничих машин та обладнання",
                    FacultyId = 5
                },
                new
                {
                    Id = 22,
                    Acronym = "Кафедра АТ",
                    Name = "Кафедра автомобільного транспорту",
                    FacultyId = 6
                },
                new
                {
                    Id = 23,
                    Acronym = "Кафедра ВМ",
                    Name = "Кафедра вищої математики",
                    FacultyId = 6
                },
                new
                {
                    Id = 24,
                    Acronym = "Кафедра ФСН",
                    Name = "Кафедра філософії і соціальних наук",
                    FacultyId = 6
                },
                new
                {
                    Id = 25,
                    Acronym = "Кафедра ФВ",
                    Name = "Кафедра фізичного виховання",
                    FacultyId = 6
                },
                new
                {
                    Id = 26,
                    Acronym = "Кафедра ФСГІР",
                    Name = "Кафедра фінансів суб’єктів господарювання та інноваційного розвитку",
                    FacultyId = 7
                },
                new
                {
                    Id = 27,
                    Acronym = "Кафедра ООПУА",
                    Name = "Кафедра обліку, оподаткування, публічного управління та адміністрування",
                    FacultyId = 7
                },
                new
                {
                    Id = 28,
                    Acronym = "Кафедра ЕОУП",
                    Name = "Кафедра економіки, організації та управління підприємствами",
                    FacultyId = 7
                },
                new
                {
                    Id = 29,
                    Acronym = "Кафедра МіА",
                    Name = "Кафедра менеджменту і адміністрування",
                    FacultyId = 7
                },
                new
                {
                    Id = 30,
                    Acronym = "Кафедра права",
                    Name = "Кафедра права",
                    FacultyId = 7
                },
                new
                {
                    Id = 31,
                    Acronym = "Кафедра АКНТ",
                    Name = "Кафедра автоматизації, комп’ютерних наук і технологій",
                    Logo = "aknt.svg",
                    Url = "aknt.knu.edu.ua",
                    Email = "aknt@knu.edu.ua",
                    Phone = "+380564090635",
                    FacultyId = 8
                },
                new
                {
                    Id = 32,
                    Acronym = "Кафедра МПЗ",
                    Name = "Кафедра моделювання і програмного забезпечення",
                    Logo = "mpz.svg",
                    Url = "mpz.knu.edu.ua",
                    Email = "mpz@knu.edu.ua",
                    Phone = "+380564090605",
                    FacultyId = 8
                },
                new
                {
                    Id = 33,
                    Acronym = "Кафедра КСМ",
                    Name = "Кафедра комп’ютерних систем та мереж",
                    Logo = "ksm.svg",
                    Url = "ksm.knu.edu.ua",
                    Email = "ksm@knu.edu.ua",
                    Phone = "+380564091720",
                    FacultyId = 8
                },
                new
                {
                    Id = 34,
                    Acronym = "Кафедра ІПМП",
                    Name = "Кафедра інженерної педагогіки та мовної підготовки",
                    Logo = "ipmp.svg",
                    Url = "ipmp.knu.edu.ua",
                    Email = "ipmp@knu.edu.ua",
                    Phone = "+380564090607",
                    FacultyId = 8
                },
                new
                {
                    Id = 35,
                    Acronym = "Кафедра ІМ",
                    Name = "Кафедра іноземних мов",
                    Logo = "im.svg",
                    Url = "im.knu.edu.ua",
                    Email = "im@knu.edu.ua",
                    Phone = "+380564090649",
                    FacultyId = 8
                }
            );
        }
    }
}