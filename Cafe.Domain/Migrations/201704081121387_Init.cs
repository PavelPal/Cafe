namespace Cafe.Domain.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderedSorts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        SortId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Sorts", t => t.SortId, cascadeDelete: true)
                .Index(t => t.SortId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        House = c.String(),
                        Appartment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sorts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderedSorts", "SortId", "dbo.Sorts");
            DropForeignKey("dbo.OrderedSorts", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderedSorts", new[] { "OrderId" });
            DropIndex("dbo.OrderedSorts", new[] { "SortId" });
            DropTable("dbo.Sorts");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderedSorts");
        }
    }
}
