namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProcurementHeaders", "PurchaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.ProcurementDetails", "CurrentDate");
            DropColumn("dbo.ProcurementHeaders", "CurrentDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProcurementHeaders", "CurrentDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ProcurementDetails", "CurrentDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.ProcurementHeaders", "PurchaseDate");
        }
    }
}
