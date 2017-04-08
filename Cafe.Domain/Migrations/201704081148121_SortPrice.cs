namespace Cafe.Domain.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class SortPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sorts", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Sorts", "HasFreeCup", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sorts", "FreeCupNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sorts", "FreeCupNumber");
            DropColumn("dbo.Sorts", "HasFreeCup");
            DropColumn("dbo.Sorts", "Price");
        }
    }
}
