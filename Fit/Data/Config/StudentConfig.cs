using Fit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Fit.Data.Config
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData
            (
                new
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Іван",
                    MiddleName = "Іванович",
                    LastName = "Іванов",
                    FirstNameEn = "Ivan",
                    MiddleNameEn = "Ivanovych",
                    LastNameEn = "Ivanov",
                    Photo = "default.png",
                    Birthday = new DateTime(2000, 7, 15),
                    PassportSerial = "AA",
                    PassportNumber = "012345",
                    TaxId = "01234567890",
                    CountryId = 1,
                    RegionId = 4,
                    CityId = 4,
                    Street = "Вул. Поштова",
                    House =  "15",
                    Appartment = "26",
                    PostCode = "50027",
                    Phone = "+380961234567",
                    Email = "ivanov@gmail.com",
                    Telegram = "@ivanov",
                    GradeBook = "123-17",
                    FundingId = 1,
                    StudyId =  1,
                    GroupId = 59,
                    SpecialtyId = 1
                }
            );
        }
    }
}