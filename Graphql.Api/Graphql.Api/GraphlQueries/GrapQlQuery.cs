using Graphql.Repositories;
using Graphql.Storage.GraphlTypes;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graphql.Api.GraphlQueries
{

    public class GrapQlQuery : ObjectGraphType
    {
        public GrapQlQuery(IBankAccountRepository bankAccountRepository, IBankRepository bankRepository)
        {
            Field<ListGraphType<BankAccountType>>(
                "bankAccounts",
                resolve: context => bankAccountRepository.Get()
            );
            Field<ListGraphType<BankType>>(
              "banks",
              resolve: context => bankRepository.Get()
          );

            Field<BankAccountType>(
                name: "bankAccountGetById",
                arguments: new QueryArguments(new
                QueryArgument<StringGraphType>
                { Name = "id" }),
                resolve: context =>
                {
                    Guid id = context.GetArgument<Guid>("id");
                    return bankAccountRepository.GetById(id);
                }
            );

        }


    }
}
