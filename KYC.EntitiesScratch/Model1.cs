namespace KYC.EntitiesScratch
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'KYC.EntitiesScratch.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
        }

        public System.Data.Entity.DbSet<KYC.EntitiesScratch.kyc_riskClass> kyc_riskClass { get; set; }

        public System.Data.Entity.DbSet<KYC.EntitiesScratch.kyc_riskCategory> kyc_riskCategory { get; set; }

        public System.Data.Entity.DbSet<KYC.EntitiesScratch.kyc_riskItem> kyc_riskItem { get; set; }

    }

}