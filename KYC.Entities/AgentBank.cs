namespace KYC.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AgentBank
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Alpha { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
    }
}
