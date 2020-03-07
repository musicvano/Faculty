using Fit.Data.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class StudyType : ObjectGraphType<Study>
    {
        public StudyType()
        {
            Name = "Study";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the study form");
            Field(x => x.Name).Description("The name of the study form");
            Field(x => x.Acronym).Description("The short name of the study form");
        }
    }
}