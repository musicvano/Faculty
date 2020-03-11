using Fit.Data.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class LocalityType : ObjectGraphType<Locality>
    {
        public LocalityType()
        {
            Name = "Locality";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the locality");
            Field(x => x.Name).Description("The name of the locality");
        }
    }
}