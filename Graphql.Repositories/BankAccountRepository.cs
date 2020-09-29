using Graphql.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Graphql.Repositories
{
    public interface IBankAccountRepository
    {
        IQueryable<BankAccountDmo> Get();
        BankAccountDmo GetById(Guid id);
    }

    public class BankAccountRepository : IBankAccountRepository
    {
        ApiContext _context;

        public BankAccountRepository(
            ApiContext context)
        {
            _context = context;
        }

        public IQueryable<BankAccountDmo> Get()
        {
           return _context.BankAccounts
                .Include(x => x.BankAccountInfo)
                .AsQueryable();
        }

        public BankAccountDmo GetById(Guid id)
        {
            var entity = _context.BankAccounts
                .Include(x => x.BankAccountInfo)
                .FirstOrDefault(x => x.Id == id);

            if(entity == null)
            {
                throw new Exception("Not Found");
            }

            return entity;
        }
    }

}