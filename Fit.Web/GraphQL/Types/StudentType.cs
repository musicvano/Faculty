using Fit.Data.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class StudentType : ObjectGraphType<Student>
    {
        public StudentType()
        {
            Name = "Student";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the student");
            Field(x => x.FirstName);
            Field(x => x.MiddleName);
            Field(x => x.LastName);
            Field(x => x.FirstNameEn);
            Field(x => x.MiddleNameEn);
            Field(x => x.LastNameEn);
            Field(x => x.Photo).Description("Filename of the photo");
            Field(x => x.Birthday);
            Field(x => x.PassportSerial);
            Field(x => x.PassportNumber);
            Field(x => x.TaxId);
            Field(x => x.Country, type: typeof(CountryType)).Description("The country of the registration");
            Field(x => x.Region, type: typeof(RegionType)).Description("The region of the registration");
            Field(x => x.City, type: typeof(CityType)).Description("The city of the registration");
            Field(x => x.Street);
            Field(x => x.House);
            Field(x => x.Appartment);
            Field(x => x.PostCode);
            Field(x => x.Phone).Description("Phone number");
            Field(x => x.Email).Description("Email address");
            Field(x => x.Telegram).Description("Telegram account"); ;
            Field(x => x.GradeBook).Description("The number of student's gradebook");
            Field(x => x.Funding, type: typeof(FundingType)).Description("The funding source");
            Field(x => x.Study, type: typeof(StudyType)).Description("The studying form");
            Field(x => x.Status, type: typeof(StatusType)).Description("The student status");
            Field(x => x.Group, type: typeof(GroupType)).Description("The academic group");
            Field(x => x.Specialty, type: typeof(SpecialtyType)).Description("The specialty of studying");
        }
    }
}