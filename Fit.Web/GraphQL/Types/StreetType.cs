using Fit.Data.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class StreetType : ObjectGraphType<Street>
    {
        public StreetType()
        {
            Name = "Street";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the street");
            Field(x => x.Name).Description("The name of the street in Ukrainian");
            Field(x => x.NameEn).Description("The name of the street in English");
            Field(x => x.Postcode).Description("Zip code of the national post service");
        }
    }
}