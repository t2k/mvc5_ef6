namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustPipelineSFLN")]
    public partial class CustPipelineSFLN
    {
        public int ID { get; set; }

        public double? Facility { get; set; }

        [StringLength(10)]
        public string SP { get; set; }

        [StringLength(10)]
        public string Moody { get; set; }

        public DateTime? BADate { get; set; }

        public double? Bid { get; set; }

        public double? Ask { get; set; }

        public DateTime? LWBADate { get; set; }

        public double? LWBid { get; set; }

        public double? LWAsk { get; set; }

        public double? LWDiff { get; set; }

        public double? LCDS3 { get; set; }

        public double? LCDS5 { get; set; }

        public double? CDS3 { get; set; }

        public double? CDS5 { get; set; }

        public double? Share { get; set; }

        public double? ShareHigh { get; set; }

        public double? ShareLow { get; set; }

        public double? Bond { get; set; }

        public double? Coupon { get; set; }

        public double? Price { get; set; }

        public DateTime? Maturity { get; set; }

        [StringLength(10)]
        public string CO { get; set; }

        public DateTime? UploadDate { get; set; }

        public double? Commitment { get; set; }

        public double? CommitmentUSD { get; set; }

        public double? GroupsUSD { get; set; }

        public double? UsedUSD { get; set; }

        public double? UnUsedUSD { get; set; }

        public string Comments { get; set; }

        [StringLength(10)]
        public string CCY { get; set; }

        [StringLength(50)]
        public string Alpha { get; set; }

        public DateTime? LastExec { get; set; }

        [StringLength(50)]
        public string FacilityType { get; set; }

        public double? Spread { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(10)]
        public string BVR2 { get; set; }
    }
}
