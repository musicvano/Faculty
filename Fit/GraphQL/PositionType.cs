using Fit.Models;
using GraphQL.Types;

namespace Fit.GraphQL
{
    public class PositionType : ObjectGraphType<Position>
    {
        public PositionType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Acronym);
        }
    }
}