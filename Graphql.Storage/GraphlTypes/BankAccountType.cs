using Graphql.Storage.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graphql.Storage.GraphlTypes
{
    public class BankAccountType : ObjectGraphType<BankAccountDmo>
    {
        public BankAccountType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Tekil guid değeri");
            Field(x => x.Name).Description("Banka Adı");
            Field(x => x.Iban).Description("Iban");
            Field<BankAccountInfoType>(nameof(BankAccountDmo.BankAccountInfo));
        }
    }
}
