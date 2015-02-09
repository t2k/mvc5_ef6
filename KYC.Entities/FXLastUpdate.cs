namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FXLastUpdate")]
    public partial class FXLastUpdate
    {
        [Key]
        public DateTime LastUpdate { get; set; }
    }
}
