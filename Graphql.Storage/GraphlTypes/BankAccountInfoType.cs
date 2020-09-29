using Graphql.Storage.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graphql.Storage.GraphlTypes
{

    public class BankAccountInfoType : ObjectGraphType<BankAccountInfoDmo>
    {
        public BankAccountInfoType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Tekil guid değeri");
            Field(x => x.TransactionTransferType).Description("Transfer Tipi");
           
        }
    }
}
