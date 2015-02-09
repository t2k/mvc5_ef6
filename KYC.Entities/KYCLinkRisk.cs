namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KYCLinkRisk")]
    public partial class KYCLinkRisk
    {
        public int ID { get; set; }

        public int? CustID { get; set; }

        public int? RiskID { get; set; }

        public virtual CUST CUST { get; set; }

        public virtual KYCStaticRisk KYCStaticRisk { get; set; }
    }
}
