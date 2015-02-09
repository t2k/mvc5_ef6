namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustPipelineComment
    {
        public int ID { get; set; }

        public int CustID { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string ReviewType { get; set; }

        [StringLength(50)]
        public string EditBy { get; set; }

        public DateTime? EditDate { get; set; }

        public string Comment { get; set; }

        [StringLength(50)]
        public string MemoType { get; set; }

        [StringLength(50)]
        public string SentBy { get; set; }

        public DateTime? SentDate { get; set; }

        [StringLength(50)]
        public string RecBy { get; set; }

        public DateTime? RecDate { get; set; }

        [StringLength(50)]
        public string MemoStatus { get; set; }

        public virtual CUSTUniversal CUSTUniversal { get; set; }
    }
}
