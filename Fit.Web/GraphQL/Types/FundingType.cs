using Fit.Data.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class FundingType : ObjectGraphType<Funding>
    {
        public FundingType()
        {
            Name = "Funding";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the funding");
            Field(x => x.Name).Description("The name of the funding");
            Field(x => x.Acronym).Description("The short name of the funding");
        }
    }
}