namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SupplierCompanies", "Email", c => c.String());
            AddColumn("dbo.SupplierCompanies", "SupplierName", c => c.String());
            DropColumn("dbo.SupplierCompanies", "SupplierInvoiceNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SupplierCompanies", "SupplierInvoiceNo", c => c.Int(nullable: false));
            DropColumn("dbo.SupplierCompanies", "SupplierName");
            DropColumn("dbo.SupplierCompanies", "Email");
        }
    }
}
