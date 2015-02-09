namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Facility
    {
        public int ID { get; set; }

        [Column("Facility")]
        [StringLength(50)]
        public string Facility1 { get; set; }
    }
}
