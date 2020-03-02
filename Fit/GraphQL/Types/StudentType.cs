using Fit.Models;
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
        }
    }
}