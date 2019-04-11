namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProcurementHeaders", "MobileNumber");
            DropColumn("dbo.ProcurementHeaders", "SupplierCompanyAddress");
            DropColumn("dbo.ProcurementHeaders", "SupplierInvoiceNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProcurementHeaders", "SupplierInvoiceNo", c => c.Int(nullable: false));
            AddColumn("dbo.ProcurementHeaders", "SupplierCompanyAddress", c => c.String());
            AddColumn("dbo.ProcurementHeaders", "MobileNumber", c => c.Int(nullable: false));
        }
    }
}
