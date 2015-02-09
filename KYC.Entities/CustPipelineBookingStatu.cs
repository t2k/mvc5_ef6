namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustPipelineBookingStatu
    {
        public int ID { get; set; }

        public int? CustID { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string CompleteBy { get; set; }

        public DateTime? CompleteDate { get; set; }

        [StringLength(50)]
        public string BookedBy { get; set; }

        public DateTime? BookedDate { get; set; }

        public string Comments { get; set; }

        public virtual CUSTUniversal CUSTUniversal { get; set; }
    }
}
