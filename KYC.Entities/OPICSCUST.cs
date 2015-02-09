namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OPICSCUST")]
    public partial class OPICSCUST
    {
        public int ID { get; set; }

        [Required]
        [StringLength(11)]
        public string CNO { get; set; }

        [StringLength(50)]
        public string CMNE { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public DateTime? OpenDate { get; set; }
    }
}
