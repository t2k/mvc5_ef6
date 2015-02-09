namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CCF")]
    public partial class CCF
    {
        public int ID { get; set; }

        public int CustID { get; set; }

        [StringLength(50)]
        public string CCFType { get; set; }

        public DateTime? EditDate { get; set; }

        public DateTime? NextDate { get; set; }

        [StringLength(50)]
        public string EditBy { get; set; }

        public string Comment { get; set; }

        public virtual CUSTUniversal CUSTUniversal { get; set; }
    }
}
