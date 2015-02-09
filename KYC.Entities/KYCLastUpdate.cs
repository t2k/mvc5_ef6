namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KYCLastUpdate")]
    public partial class KYCLastUpdate
    {
        [Key]
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdate { get; set; }
    }
}
