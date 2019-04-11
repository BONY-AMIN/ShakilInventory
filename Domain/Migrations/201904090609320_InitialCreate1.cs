namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "BrandId", c => c.Int());
            AddColumn("dbo.Items", "ModelId", c => c.Int());
            CreateIndex("dbo.Items", "BrandId");
            CreateIndex("dbo.Items", "ModelId");
            AddForeignKey("dbo.Items", "BrandId", "dbo.Brands", "BrandId");
            AddForeignKey("dbo.Items", "ModelId", "dbo.Models", "ModelId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "ModelId", "dbo.Models");
            DropForeignKey("dbo.Items", "BrandId", "dbo.Brands");
            DropIndex("dbo.Items", new[] { "ModelId" });
            DropIndex("dbo.Items", new[] { "BrandId" });
            DropColumn("dbo.Items", "ModelId");
            DropColumn("dbo.Items", "BrandId");
        }
    }
}
