using Graphql.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graphql.Repositories
{

    public class ApiContext : DbContext
    {

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = true;
        }

        public DbSet<BankAccountDmo> BankAccounts { get; set; }
        public DbSet<BankAccountInfoDmo> BankAccountInfos { get; set; }
        public DbSet<BankDmo> Banks { get; set; }      
        public DbSet<TenantBankDmo> TenantBanks { get; set; }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            base.OnModelCreating(modelBuilder);

      
        }
    }
}
