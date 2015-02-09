namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kyc_riskItem
    {
        public int ID { get; set; }

        [Required]
        [StringLength(140)]
        public string Description { get; set; }

        public int CategoryID { get; set; }

        public int ClassID { get; set; }

        [Range(1,100)]
        public int Score { get; set; }

        [Range (1,1000)]
        public int Ordinal { get; set; }

        public virtual kyc_riskCategory Category { get; set; }
        public virtual kyc_riskClass Class { get; set; }
    }
}
