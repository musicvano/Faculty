using Fit.Models;
using GraphQL.Types;

namespace Fit.GraphQL
{
    public class DegreeType : ObjectGraphType<Degree>
    {
        public DegreeType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Acronym);
        }
    }
}