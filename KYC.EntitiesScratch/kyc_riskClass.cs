namespace KYC.EntitiesScratch
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kyc_riskClass
    {
        public int Id { get; set; }

        [StringLength(20, MinimumLength=1)]
        [Display(Name="Risk Class")]
        public string Class { get; set; }

        [Display(Name = "Risk Score")]
        [Range(1,100)]
        public int Score { get; set; }

        [Display(Name = "Sort Order")]
        public int Ordinal { get; set; }
    }
}
