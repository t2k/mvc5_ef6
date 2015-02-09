namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FromAccessAcctstoClose")]
    public partial class FromAccessAcctstoClose
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string OPICSref { get; set; }

        [StringLength(100)]
        public string SName { get; set; }

        [StringLength(50)]
        public string CMNE { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }
    }
}
