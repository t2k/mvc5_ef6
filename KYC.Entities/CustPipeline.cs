namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustPipeline")]
    public partial class CustPipeline
    {
        public int ID { get; set; }

        public int CustID { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public DateTime? StatusChangeDate { get; set; }

        public int? SponsorID { get; set; }

        public int? SectorID { get; set; }

        public bool? RatingSegment { get; set; }

        [StringLength(50)]
        public string Rating { get; set; }

        public DateTime? RatingDate { get; set; }

        public double? TransactionSize { get; set; }

        public double? CapitalRequired { get; set; }

        public bool? ApprovalLevel { get; set; }

        public DateTime? PipelineSubDate { get; set; }

        public DateTime? PipelineNDMDate { get; set; }

        public DateTime? PipelineDecisionDate { get; set; }

        [StringLength(50)]
        public string PipelineDecision { get; set; }

        [StringLength(50)]
        public string PipelineDecisionBy { get; set; }

        public DateTime? PipelineDeadline { get; set; }

        public DateTime? CreditNYSubDate { get; set; }

        public DateTime? CreditNYDecisionDate { get; set; }

        [StringLength(50)]
        public string CreditNYDecision { get; set; }

        [StringLength(50)]
        public string CreditNYDecisionBy { get; set; }

        public DateTime? CreditFFKTSubDate { get; set; }

        public DateTime? CreditFFKTDecisionDate { get; set; }

        [StringLength(50)]
        public string CreditFFKTDecision { get; set; }

        [StringLength(50)]
        public string CreditFFKTDecisionBy { get; set; }

        public DateTime? CreditDeadline { get; set; }

        public DateTime? ReviewDate { get; set; }

        [StringLength(50)]
        public string ReviewType { get; set; }

        public string Comment { get; set; }

        [StringLength(50)]
        public string LoanRef { get; set; }

        [StringLength(50)]
        public string EditBy { get; set; }

        public DateTime? EditDate { get; set; }

        [StringLength(50)]
        public string ReportValue { get; set; }

        public DateTime? Deadline { get; set; }

        public virtual CUSTUniversal CUSTUniversal { get; set; }
    }
}
