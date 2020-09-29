using Graphql.Storage.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetBankaGold.Storage.Entities
{
    [Table("BankAccountHashedValues")]
    public class BankAccountHashedValueDmo : BaseGuidEntity
    {
        [ForeignKey("BankAccount")]
        public Guid BankAccountGuid { get; set; }
        public BankAccountDmo BankAccount { get; set; }
        public string HashedValue { get; set; }
        public string BankEftCode { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
