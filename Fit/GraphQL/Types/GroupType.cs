using Fit.Models;
using GraphQL.Types;

namespace Fit.GraphQL.Types
{
    public class GroupType : ObjectGraphType<Group>
    {
        public GroupType()
        {
            Name = "Group";
            Field(x => x.Id).Description("The ID of the academic group");
            Field(x => x.Name).Description("The name of the group");
            Field(x => x.Faculty, type: typeof(FacultyType)).Description("The faculty of the group");
            Field(x => x.Students, type: typeof(ListGraphType<StudentType>)).Description("Students of the group");
        }
    }
}