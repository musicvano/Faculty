using Fit.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class PositionType : ObjectGraphType<Position>
    {
        public PositionType()
        {
            Name = "Position";
            Field(x => x.Id).Description("The ID of the position");
            Field(x => x.Name).Description("The name of the position");
            Field(x => x.Acronym).Description("Short name of the position");
        }
    }
}