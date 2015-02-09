namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sector")]
    public partial class Sector
    {
        public int ID { get; set; }

        [Column("Sector")]
        [Required]
        [StringLength(50)]
        public string Sector1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }
    }
}
