namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSTUniversal")]
    public partial class CUSTUniversal
    {
        public CUSTUniversal()
        {
            CCFs = new HashSet<CCF>();
            CustPipelines = new HashSet<CustPipeline>();
            CustPipelineBookingStatus = new HashSet<CustPipelineBookingStatu>();
            CustPipelineComments = new HashSet<CustPipelineComment>();
            CustPipelineDecisionHistories = new HashSet<CustPipelineDecisionHistory>();
            CustPipelineFacilities = new HashSet<CustPipelineFacility>();
            CustPipelineLinkeds = new HashSet<CustPipelineLinked>();
            ReferenceExternalAccts = new HashSet<ReferenceExternalAcct>();
            ReferenceInternalAccts = new HashSet<ReferenceInternalAcct>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? AcctOpenDate { get; set; }

        [ScaffoldColumn(false)]
        [StringLength(50)]
        public string AcctOpenBy { get; set; }

        [StringLength(50)]
        public string Owner { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? EditDate { get; set; }

        [StringLength(50)]
        public string EditBy { get; set; }

        [StringLength(50)]
        public string KYCStatus { get; set; }

        [StringLength(50)]
        public string CreditStatus { get; set; }

        [StringLength(50)]
        public string CustStatus { get; set; }

        public virtual ICollection<CCF> CCFs { get; set; }

        public virtual CUST CUST { get; set; }

        public virtual CUSTDetail CUSTDetail { get; set; }

        public virtual ICollection<CustPipeline> CustPipelines { get; set; }

        public virtual ICollection<CustPipelineBookingStatu> CustPipelineBookingStatus { get; set; }

        public virtual ICollection<CustPipelineComment> CustPipelineComments { get; set; }

        public virtual ICollection<CustPipelineDecisionHistory> CustPipelineDecisionHistories { get; set; }

        public virtual ICollection<CustPipelineFacility> CustPipelineFacilities { get; set; }

        public virtual ICollection<CustPipelineLinked> CustPipelineLinkeds { get; set; }

        public virtual ICollection<ReferenceExternalAcct> ReferenceExternalAccts { get; set; }

        public virtual ICollection<ReferenceInternalAcct> ReferenceInternalAccts { get; set; }
    }
}
