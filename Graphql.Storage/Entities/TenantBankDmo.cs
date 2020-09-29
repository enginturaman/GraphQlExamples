using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Graphql.Storage.Entities
{
    [Table("TenantBanks")]
    public class TenantBankDmo : BaseGuidEntity
    {
        [ForeignKey("Bank")]
        public int BankId { get; set; }
        public BankDmo Bank { get; set; }

        public Guid TenantId { get; set; }

        public virtual ICollection<BankAccountDmo> BankAccounts { get; set; }
        
        public string MerchantCode { get; set; }
    }
}
