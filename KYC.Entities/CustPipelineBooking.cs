namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustPipelineBooking")]
    public partial class CustPipelineBooking
    {
        public int ID { get; set; }

        public int? CustID { get; set; }

        public int? FacilityID { get; set; }

        public double? Allocation { get; set; }
    }
}
