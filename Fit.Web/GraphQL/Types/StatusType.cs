using Fit.Data.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class StatusType : ObjectGraphType<Status>
    {
        public StatusType()
        {
            Name = "Status";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the status");
            Field(x => x.Name).Description("The name of the status");
        }
    }
}