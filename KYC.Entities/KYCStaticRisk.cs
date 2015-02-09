namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KYCStaticRisk")]
    public partial class KYCStaticRisk
    {
        public KYCStaticRisk()
        {
            KYCLinkRisks = new HashSet<KYCLinkRisk>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string Category { get; set; }

        [StringLength(50)]
        public string Rating { get; set; }

        public double? Score { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(50)]
        public string AutoTo { get; set; }

        [StringLength(50)]
        public string Active { get; set; }

        [StringLength(50)]
        public string EditBy { get; set; }

        public DateTime? EditDate { get; set; }

        public virtual ICollection<KYCLinkRisk> KYCLinkRisks { get; set; }
    }
}
