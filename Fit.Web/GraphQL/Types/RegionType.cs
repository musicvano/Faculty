using Fit.Data.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class RegionType : ObjectGraphType<Region>
    {
        public RegionType()
        {
            Name = "Region";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the region");
            Field(x => x.Name).Description("The name of the region");
            Field(x => x.Acronym).Description("Short name of the region");
        }
    }
}