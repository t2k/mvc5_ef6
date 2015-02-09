namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kyc_riskClass
    {
        public int ID { get; set; }

        [Key]
        [StringLength(20)]
        public string Name { get; set; }

        [Range(1,100)]
        public int Score { get; set; }

        public int Ordinal { get; set; }

        //public virtual ICollection<kyc_riskrating> kyc_riskrating { get; set; }
    }
}
