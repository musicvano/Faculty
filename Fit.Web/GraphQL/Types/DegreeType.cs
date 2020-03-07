using Fit.Data.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class DegreeType : ObjectGraphType<Degree>
    {
        public DegreeType()
        {
            Name = "Degree";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the degree");
            Field(x => x.Name).Description("The name of the degree");
            Field(x => x.Acronym).Description("Short name of the degree");
        }
    }
}