using Fit.Data.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class CityType : ObjectGraphType<City>
    {
        public CityType()
        {
            Name = "City";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the city");
            Field(x => x.Name).Description("The name of the city");
        }
    }
}