namespace KYC.EntitiesScratch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class riskItemlookups4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.kyc_riskCategory", "Cateogory", c => c.String(maxLength: 50));
            AddColumn("dbo.kyc_riskClass", "Class", c => c.String(maxLength: 20));
            DropColumn("dbo.kyc_riskCategory", "Name");
            DropColumn("dbo.kyc_riskClass", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.kyc_riskClass", "Name", c => c.String(maxLength: 20));
            AddColumn("dbo.kyc_riskCategory", "Name", c => c.String(maxLength: 50));
            DropColumn("dbo.kyc_riskClass", "Class");
            DropColumn("dbo.kyc_riskCategory", "Cateogory");
        }
    }
}
