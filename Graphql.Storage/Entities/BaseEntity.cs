using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Graphql.Storage.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }

    public class BaseInfoEntity : BaseEntity
    {
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool Deleted { get; set; }
    }

    public abstract class BaseGuidEntity
    {
        [Key]
        public Guid Id { get; set; }
    }

    public class BaseGuidInfoEntity : BaseGuidEntity
    {
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool Deleted { get; set; }
    }

}

