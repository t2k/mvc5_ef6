namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReferenceInternalGeneral")]
    public partial class ReferenceInternalGeneral
    {
        public int ID { get; set; }

        public int? AcctID { get; set; }

        public DateTime? UploadDate { get; set; }

        [StringLength(50)]
        public string UploadBy { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(200)]
        public string Link { get; set; }
    }
}
