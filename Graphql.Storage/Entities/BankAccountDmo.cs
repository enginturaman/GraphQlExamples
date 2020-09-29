using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Graphql.Storage.Entities
{
    [Table("BankAccounts")]
    public class BankAccountDmo : BaseGuidInfoEntity
    {
        [ForeignKey("TenantBank")]
        public Guid TenantBankGuid { get; set; }
        public TenantBankDmo TenantBank { get; set; }

        public string Name { get; set; }

        public string AccountNumber { get; set; }

        public string BranchName { get; set; }

        public string BranchNumber { get; set; }

        public string Iban { get; set; }

        public string ErpCode { get; set; }

        public bool IsActive { get; set; }

        public Guid TenantGuid { get; set; }

        public string CurrencyCode { get; set; }

        public BankAccountInfoDmo BankAccountInfo { get; set; }
    }
}
