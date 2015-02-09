namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustPipelineRatingHistory")]
    public partial class CustPipelineRatingHistory
    {
        public int ID { get; set; }

        public int? CustID { get; set; }

        public bool? RatingSegment { get; set; }

        [StringLength(50)]
        public string Rating { get; set; }

        public DateTime? RatingDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ChangeDate { get; set; }

        [StringLength(50)]
        public string ChangeBy { get; set; }
    }
}
