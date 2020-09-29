using Graphql.Storage.GraphlModels;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graphql.Storage.GraphlTypes
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType()
        {
            Name = "Author";
            Field(_ => _.Id).Description("Author's Id.");
            Field(_ => _.FirstName).Description
            ("Yazarın Adı");
            Field(_ => _.LastName).Description
            ("Yazarın Soyadı");
        }
    }
}
