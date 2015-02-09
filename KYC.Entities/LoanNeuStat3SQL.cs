namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LoanNeuStat3SQL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string OPICSRef { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FacilityID { get; set; }

        public double? FacilityAmt { get; set; }

        public double? FacilityUnused { get; set; }

        public DateTime? MaturityDate { get; set; }

        public DateTime? UploadDate { get; set; }
    }
}
