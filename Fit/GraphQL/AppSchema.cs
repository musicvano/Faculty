using GraphQL;
using GraphQL.Types;

namespace Fit.GraphQL
{
    public class AppSchema : Schema
    {
        public AppSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<RootQuery>();
        }
    }
}