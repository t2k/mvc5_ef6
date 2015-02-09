namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustPipelineFacility")]
    public partial class CustPipelineFacility
    {
        public CustPipelineFacility()
        {
            CustPipelineFacilityDetails = new HashSet<CustPipelineFacilityDetail>();
        }

        public int ID { get; set; }

        public int CustID { get; set; }

        [StringLength(50)]
        public string FacilityType { get; set; }

        [StringLength(50)]
        public string Currency { get; set; }

        public double? FX { get; set; }

        public double? GlobalFacility { get; set; }

        public double? RequestedCommitment { get; set; }

        public double? ApprovedCommitment { get; set; }

        public bool? Approved { get; set; }

        public double? GlobalUSD { get; set; }

        public double? RequestedUSD { get; set; }

        public double? ApprovedUSD { get; set; }

        [StringLength(50)]
        public string EditBy { get; set; }

        public DateTime? EditDate { get; set; }

        public virtual CUSTUniversal CUSTUniversal { get; set; }

        public virtual ICollection<CustPipelineFacilityDetail> CustPipelineFacilityDetails { get; set; }
    }
}
