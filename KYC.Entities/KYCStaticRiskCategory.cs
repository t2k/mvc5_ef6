namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KYCStaticRiskCategory
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Category { get; set; }

        [StringLength(50)]
        public string Active { get; set; }

        [StringLength(50)]
        public string EditBy { get; set; }

        public DateTime? EditDate { get; set; }
    }
}
