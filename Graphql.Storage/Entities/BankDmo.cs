using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Graphql.Storage.Entities
{

    [Table("Banks")]
    public class BankDmo : BaseEntity
    {
        public string Name { get; set; }
        public string EftCode { get; set; }

        public string ColorCode { get; set; }

        public string LogoSmall { get; set; }

        public string LogoMedium { get; set; }

        public string LogoBig { get; set; }

        public List<TenantBankDmo> TenantBanks { get; set; }
    }
}
