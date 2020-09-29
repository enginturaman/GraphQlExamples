using Graphql.Api.GraphlQueries;
using GraphQL;
using GraphQL.Types;
namespace Graphql.Api
{
    public class GraphQLDemoSchema : Schema, ISchema
    {
        public GraphQLDemoSchema(IDependencyResolver resolver) : base(resolver)
        {
           Query = resolver.Resolve<GrapQlQuery>();
        }

    }
}
