namespace EasyApi2.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCategoryAddOrderName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Name", c => c.String());
            DropColumn("dbo.Products", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Category", c => c.String());
            DropColumn("dbo.Orders", "Name");
        }
    }
}
