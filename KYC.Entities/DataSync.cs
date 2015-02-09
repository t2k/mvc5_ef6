namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataSync")]
    public partial class DataSync
    {
        [StringLength(5)]
        public string ID { get; set; }

        [StringLength(50)]
        public string DataType { get; set; }

        public DateTime? SyncDate { get; set; }

        [StringLength(50)]
        public string SyncBy { get; set; }

        public DateTime? DataVaild { get; set; }
    }
}
