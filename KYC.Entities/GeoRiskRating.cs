namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GeoRiskRating
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GeoID { get; set; }

        [StringLength(255)]
        public string Country { get; set; }

        [StringLength(50)]
        public string RiskClassUS { get; set; }

        public DateTime? RatingDate { get; set; }
    }
}
