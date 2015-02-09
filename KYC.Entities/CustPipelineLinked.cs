namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustPipelineLinked")]
    public partial class CustPipelineLinked
    {
        public int ID { get; set; }

        public int? CustID { get; set; }

        public int? LinkedID { get; set; }

        [StringLength(50)]
        public string LinkedBy { get; set; }

        public DateTime? LinkedDate { get; set; }

        public bool? WFOnly { get; set; }

        public virtual CUSTUniversal CUSTUniversal { get; set; }
    }
}
