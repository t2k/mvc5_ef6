namespace KYC.EntitiesScratch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class riskItemlookups : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.kyc_riskCategory", "kyc_riskItem_Id", "dbo.kyc_riskItem");
            DropForeignKey("dbo.kyc_riskClass", "kyc_riskItem_Id", "dbo.kyc_riskItem");
            DropIndex("dbo.kyc_riskCategory", new[] { "kyc_riskItem_Id" });
            DropIndex("dbo.kyc_riskClass", new[] { "kyc_riskItem_Id" });
            AddColumn("dbo.kyc_riskItem", "kyc_riskCategoryID", c => c.Int(nullable: false));
            AddColumn("dbo.kyc_riskItem", "kyc_riskClassID", c => c.Int(nullable: false));
            DropColumn("dbo.kyc_riskCategory", "kyc_riskItem_Id");
            DropColumn("dbo.kyc_riskClass", "kyc_riskItem_Id");
            DropColumn("dbo.kyc_riskItem", "CategoryID");
            DropColumn("dbo.kyc_riskItem", "ClassID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.kyc_riskItem", "ClassID", c => c.Int(nullable: false));
            AddColumn("dbo.kyc_riskItem", "CategoryID", c => c.Int(nullable: false));
            AddColumn("dbo.kyc_riskClass", "kyc_riskItem_Id", c => c.Int());
            AddColumn("dbo.kyc_riskCategory", "kyc_riskItem_Id", c => c.Int());
            DropColumn("dbo.kyc_riskItem", "kyc_riskClassID");
            DropColumn("dbo.kyc_riskItem", "kyc_riskCategoryID");
            CreateIndex("dbo.kyc_riskClass", "kyc_riskItem_Id");
            CreateIndex("dbo.kyc_riskCategory", "kyc_riskItem_Id");
            AddForeignKey("dbo.kyc_riskClass", "kyc_riskItem_Id", "dbo.kyc_riskItem", "Id");
            AddForeignKey("dbo.kyc_riskCategory", "kyc_riskItem_Id", "dbo.kyc_riskItem", "Id");
        }
    }
}
