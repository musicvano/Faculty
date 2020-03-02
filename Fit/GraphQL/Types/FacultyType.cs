using Fit.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class FacultyType : ObjectGraphType<Faculty>
    {
        public FacultyType()
        {
            Name = "Faculty";
            Field(x => x.Id).Description("The ID of the faculty");
            Field(x => x.Name).Description("The name of the faculty");
            Field(x => x.Acronym).Description("The short name of the faculty");
            Field(x => x.Departments, type: typeof(ListGraphType<DepartmentType>)).Description("Departments of the faculty");
        }
    }
}