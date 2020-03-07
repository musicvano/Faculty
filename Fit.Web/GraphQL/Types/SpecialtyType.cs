using Fit.Data.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class SpecialtyType : ObjectGraphType<Specialty>
    {
        public SpecialtyType()
        {
            Name = "Specialty";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the specialty");
            Field(x => x.Code).Description("The code of the specialty");
            Field(x => x.Name).Description("The name of the specialty");
        }
    }
}