namespace KYC.EntitiesScratch
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kyc_riskCategory
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength=3)]
        [Display(Name="Risk Category")]
        public string Cateogory { get; set; }
        [Display(Name="Sort Order")]
        public int Ordinal { get; set; }
    }
}
