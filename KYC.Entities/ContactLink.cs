namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactLink")]
    public partial class ContactLink
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CustID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ContactID { get; set; }
    }
}
