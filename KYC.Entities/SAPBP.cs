namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAPBP")]
    public partial class SAPBP
    {
        public int ID { get; set; }

        [Required]
        [StringLength(8)]
        public string BP { get; set; }

        [StringLength(100)]
        public string BPName { get; set; }

        public int? KYCID { get; set; }
    }
}
