using Fit.Data.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class RankType : ObjectGraphType<Rank>
    {
        public RankType()
        {
            Name = "Rank";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the rank");
            Field(x => x.Name).Description("The name of the rank");
            Field(x => x.Acronym).Description("Short name of the rank");
        }
    }
}