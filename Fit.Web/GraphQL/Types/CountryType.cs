using Fit.Data.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class CountryType : ObjectGraphType<Country>
    {
        public CountryType()
        {
            Name = "Country";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the country");
            Field(x => x.Code).Description("The code of the country according to ISO 3166-1 alpha-3");
            Field(x => x.Name).Description("The name of the country");
        }
    }
}