namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChangeInfo")]
    public partial class ChangeInfo
    {
        public int ID { get; set; }

        public int CustID { get; set; }

        public DateTime ChangeDate { get; set; }

        [Required]
        [StringLength(50)]
        public string ChangeType { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        [Required]
        [StringLength(50)]
        public string OldScore { get; set; }

        [Required]
        [StringLength(50)]
        public string NewScore { get; set; }

        public string Comments { get; set; }
    }
}
