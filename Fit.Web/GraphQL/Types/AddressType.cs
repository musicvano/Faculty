using Fit.Data.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class AddressType : ObjectGraphType<Address>
    {
        public AddressType()
        {
            Name = "Address";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the address");
            Field(x => x.Street, type: typeof(StreetType)).Description("The street");
            Field(x => x.House).Description("House number");
            Field(x => x.Apartment).Description("Apartment number");
        }
    }
}