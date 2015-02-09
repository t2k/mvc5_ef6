namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustPipelineFacilityDetail")]
    public partial class CustPipelineFacilityDetail
    {
        public int ID { get; set; }

        public int? FacilityID { get; set; }

        public bool? MultiCCy { get; set; }

        public DateTime? EffDate { get; set; }

        public DateTime? MatDate { get; set; }

        public bool? FacReduction { get; set; }

        public bool? BranchLimit { get; set; }

        public bool? OtherEligible { get; set; }

        public bool? Comm { get; set; }

        public bool? Advance { get; set; }

        public bool? PurchaseDraft { get; set; }

        public bool? LoanGuarantee { get; set; }

        public bool? StandbyLC { get; set; }

        public bool? DocLC { get; set; }

        [StringLength(50)]
        public string AgentBank { get; set; }

        public bool? Syndicated { get; set; }

        [StringLength(50)]
        public string Purpose { get; set; }

        public bool? Secured { get; set; }

        public double? AdvLIBORMargin { get; set; }

        [StringLength(50)]
        public string AdvLIBORBasis { get; set; }

        [StringLength(50)]
        public string AdvLIBORIntPay { get; set; }

        public double? AdvCOFMargin { get; set; }

        [StringLength(50)]
        public string AdvCOFBasis { get; set; }

        [StringLength(50)]
        public string AdvCOFIntPay { get; set; }

        public double? AdvFixedMargin { get; set; }

        [StringLength(50)]
        public string AdvFixedBasis { get; set; }

        [StringLength(50)]
        public string AdvFixedIntPay { get; set; }

        public double? AdvPrimeMargin { get; set; }

        [StringLength(50)]
        public string AdvPrimeBasis { get; set; }

        [StringLength(50)]
        public string AdvPrimeIntPay { get; set; }

        [StringLength(50)]
        public string DraftType { get; set; }

        public double? DraftMargin { get; set; }

        [StringLength(50)]
        public string DraftBasis { get; set; }

        [StringLength(50)]
        public string DraftIntPay { get; set; }

        public double? LCMargin { get; set; }

        [StringLength(50)]
        public string LCBasis { get; set; }

        [StringLength(50)]
        public string LCIntPay { get; set; }

        public double? LCSubLimit { get; set; }

        public double? FacCommFeeMargin { get; set; }

        [StringLength(50)]
        public string FacCommFeeBasis { get; set; }

        [StringLength(50)]
        public string FacCommFeeIntPay { get; set; }

        public double? FacFacilityFeeMargin { get; set; }

        [StringLength(50)]
        public string FacFacilityFeeBasis { get; set; }

        [StringLength(50)]
        public string FacFacilityFeeIntPay { get; set; }

        public double? FacUpfrontFeeMargin { get; set; }

        [StringLength(50)]
        public string FacUpfrontFeeBasis { get; set; }

        [StringLength(50)]
        public string FacUpfrontFeeIntPay { get; set; }

        [StringLength(50)]
        public string ProfitCenter { get; set; }

        [StringLength(100)]
        public string FacilityDescription { get; set; }

        public virtual CustPipelineFacility CustPipelineFacility { get; set; }
    }
}
