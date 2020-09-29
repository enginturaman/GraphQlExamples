using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Graphql.Storage.Entities
{
    [Table("BankAccountInfos")]
    public class BankAccountInfoDmo : BaseGuidInfoEntity
    {
        public Guid BankAccountId { get; set; }

        public BankAccountDmo BankAccount { get; set; }

        public DateTime? LastSuccessfulRequestDate { get; set; }

        public int? LastSuccessfulTransactionCount { get; set; }

        public int TransactionTransferType { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Balance { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal FreeRate { get; set; }

    }
}
