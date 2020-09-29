using Graphql.Repositories;
using Graphql.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphql.Services
{
    public interface IBankAccountService
    {
        IQueryable<BankAccountDmo> Get();
    }

    public class BankAccountService : IBankAccountService
    {
        readonly IBankAccountRepository _bankAccountRepository;

        public BankAccountService(
            IBankAccountRepository bankAccountRepository)
        {
            _bankAccountRepository = bankAccountRepository;
        }

        public IQueryable<BankAccountDmo> Get()
        {
            return _bankAccountRepository.Get();
        }
    }
}
