namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KYCGeoRiskLinkTemp")]
    public partial class KYCGeoRiskLinkTemp
    {
        public int ID { get; set; }

        public int? CustID { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string Rating { get; set; }

        public virtual CUST CUST { get; set; }
    }
}
