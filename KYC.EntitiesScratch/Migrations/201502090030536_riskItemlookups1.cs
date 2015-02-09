namespace KYC.EntitiesScratch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class riskItemlookups1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.kyc_riskItem", "kyc_riskCategoryID");
            CreateIndex("dbo.kyc_riskItem", "kyc_riskClassID");
            AddForeignKey("dbo.kyc_riskItem", "kyc_riskClassID", "dbo.kyc_riskClass", "Id", cascadeDelete: true);
            AddForeignKey("dbo.kyc_riskItem", "kyc_riskCategoryID", "dbo.kyc_riskCategory", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.kyc_riskItem", "kyc_riskCategoryID", "dbo.kyc_riskCategory");
            DropForeignKey("dbo.kyc_riskItem", "kyc_riskClassID", "dbo.kyc_riskClass");
            DropIndex("dbo.kyc_riskItem", new[] { "kyc_riskClassID" });
            DropIndex("dbo.kyc_riskItem", new[] { "kyc_riskCategoryID" });
        }
    }
}
