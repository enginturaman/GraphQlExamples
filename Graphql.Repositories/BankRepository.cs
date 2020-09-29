using Graphql.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphql.Repositories
{
    public interface IBankRepository
    {
        IQueryable<BankDmo> Get();
    }

    public class BankRepository : IBankRepository
    {
        ApiContext _context;

        public BankRepository(
            ApiContext context)
        {
            _context = context;
        }

        public IQueryable<BankDmo> Get()
        {
            return _context.Banks;
        }

    }

}