using Fit.Models;
using GraphQL.Types;

namespace Fit.GraphQL
{
    public class RankType : ObjectGraphType<Rank>
    {
        public RankType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Acronym);
        }
    }
}