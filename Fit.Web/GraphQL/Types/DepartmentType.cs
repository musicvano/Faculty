using Fit.Data.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class DepartmentType : ObjectGraphType<Department>
    {
        public DepartmentType()
        {
            Name = "Department";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the department");
            Field(x => x.Name).Description("The name of the department");
            Field(x => x.Acronym).Description("Short name of the department");
            Field(x => x.Logo, nullable: true).Description("The name of the logo file");
            Field(x => x.Email, nullable: true).Description("Email address of the department");
            Field(x => x.Url, nullable: true).Description("Official website of the department");
        }
    }
}