namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSTDetail")]
    public partial class CUSTDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(100)]
        public string SName { get; set; }

        [StringLength(100)]
        public string COName { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(50)]
        public string PostCode { get; set; }

        [StringLength(100)]
        public string CityState { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(50)]
        public string AccountMgr { get; set; }

        [StringLength(50)]
        public string CreditMgr { get; set; }

        [StringLength(50)]
        public string OPICSref { get; set; }

        [StringLength(50)]
        public string MUREXref { get; set; }

        [StringLength(10)]
        public string CMNE { get; set; }

        [StringLength(50)]
        public string SAP { get; set; }

        [StringLength(100)]
        public string LName { get; set; }

        [StringLength(100)]
        public string LStreet { get; set; }

        [StringLength(50)]
        public string LPostCode { get; set; }

        [StringLength(100)]
        public string LCityState { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? AcctCloseDate { get; set; }

        public DateTime? EditDate { get; set; }

        [StringLength(50)]
        public string EditBy { get; set; }

        public string Comments { get; set; }

        public virtual CUSTUniversal CUSTUniversal { get; set; }
    }
}
