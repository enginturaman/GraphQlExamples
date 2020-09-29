using GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphql.Storage.GraphlModels
{
    public class Query
    {

        [GraphQLMetadata("books")]
        public IEnumerable<Book> GetBooks()
        {
            return Enumerable.Empty<Book>();
        }

        [GraphQLMetadata("authors")]
        public IEnumerable<Author> GetAuthors()
        {
            return Enumerable.Empty<Author>();
        }

        [GraphQLMetadata("author")]
        public Author GetAuthor(int id)
        {
            return null;
        }

        [GraphQLMetadata("hello")]
        public string GetHello()
        {
            return "World";
        }
    }
}
