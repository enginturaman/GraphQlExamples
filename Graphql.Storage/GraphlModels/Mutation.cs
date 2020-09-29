using GraphQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graphql.Storage.GraphlModels
{
    [GraphQLMetadata("Mutation")]
    public class Mutation
    {
        [GraphQLMetadata("addAuthor")]
        public Author Add(string name)
        {
            return null;
        }
    }
}
