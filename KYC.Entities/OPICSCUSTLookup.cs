namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OPICSCUSTLookup")]
    public partial class OPICSCUSTLookup
    {
        public long ID { get; set; }

        [StringLength(11)]
        public string CNO { get; set; }

        [StringLength(50)]
        public string CMNE { get; set; }

        [StringLength(100)]
        public string CFN1 { get; set; }

        [StringLength(50)]
        public string SN { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}
