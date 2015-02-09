namespace KYC.EntitiesScratch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class riskItemlookups3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.kyc_riskItem", new[] { "kyc_riskCategoryID" });
            DropIndex("dbo.kyc_riskItem", new[] { "kyc_riskClassID" });
            CreateIndex("dbo.kyc_riskItem", "kyc_riskCategoryId");
            CreateIndex("dbo.kyc_riskItem", "kyc_riskClassId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.kyc_riskItem", new[] { "kyc_riskClassId" });
            DropIndex("dbo.kyc_riskItem", new[] { "kyc_riskCategoryId" });
            CreateIndex("dbo.kyc_riskItem", "kyc_riskClassID");
            CreateIndex("dbo.kyc_riskItem", "kyc_riskCategoryID");
        }
    }
}
