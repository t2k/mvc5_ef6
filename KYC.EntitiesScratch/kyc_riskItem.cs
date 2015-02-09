namespace KYC.EntitiesScratch
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kyc_riskItem
    {
        public int Id { get; set; }
        [StringLength(140, MinimumLength=5)]
        public string Description { get; set; }

        [Display(Name="Risk Category")]
        public int kyc_riskCategoryId { get; set; }
        [Display(Name = "Risk Class")]
        public int kyc_riskClassId { get; set; }

        [Range(1,100)]
        public int Score { get; set; }
        [Range (1,1000)]
        public int Ordinal { get; set; }

        [Display(Name="RiskCategory")]
        public virtual kyc_riskCategory RiskCategory { get; set; }
        [Display(Name = "RiskClass")]
        public virtual kyc_riskClass RiskClass { get; set; }
    }
}
