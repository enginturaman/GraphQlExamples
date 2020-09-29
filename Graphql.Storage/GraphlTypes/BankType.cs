using Graphql.Storage.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graphql.Storage.GraphlTypes
{
    public class BankType : ObjectGraphType<BankDmo>
    {
        public BankType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Tekil guid değeri");
            Field(x => x.Name).Description("Banka Adı");
            Field(x => x.EftCode).Description("Eft Kodu");
        }
    }
}
