namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SPRating")]
    public partial class SPRating
    {
        [StringLength(50)]
        public string Sort { get; set; }

        [Key]
        [StringLength(50)]
        public string Rating { get; set; }
    }
}
