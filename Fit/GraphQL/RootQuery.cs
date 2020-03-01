using Fit.Data;
using GraphQL.Types;
using System.Collections.Generic;
using System.Linq;

namespace Fit.GraphQL
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery(DataContext context)
        {
            Field<ListGraphType<RankType>>(
                "ranks",
                arguments: new QueryArguments(new List<QueryArgument> {
                    new QueryArgument<IdGraphType> { Name = "id" },
                    new QueryArgument<StringGraphType> { Name = "acronym" },
                    new QueryArgument<StringGraphType> { Name = "name" }
                }),
                resolve: data =>
                {
                    return context.Ranks.ToList();
                }
            );

            Field<ListGraphType<PositionType>>(
                "positions",
                arguments: new QueryArguments(new List<QueryArgument> {
                    new QueryArgument<IdGraphType> { Name = "id" },
                    new QueryArgument<StringGraphType> { Name = "acronym" },
                    new QueryArgument<StringGraphType> { Name = "name" }
                }),
                resolve: data =>
                {
                    return context.Positions.ToList();
                }
            );
        }
    }
}
