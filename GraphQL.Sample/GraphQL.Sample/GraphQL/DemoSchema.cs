using GraphQL.Types;
using GraphQL.Sample.GraphQL.Queries;

namespace GraphQL.Sample.GraphQL
{
    public class DemoSchema : Schema
{
    public DemoSchema(IDependencyResolver resolver) : base(resolver)
    {
        Query = resolver.Resolve<CustomerQuery>();
    }
}
}