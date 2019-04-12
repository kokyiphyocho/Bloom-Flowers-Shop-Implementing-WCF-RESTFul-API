namespace BloomWCFService.Data.Migrations.BouquetDB
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialConfig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bouquets",
                c => new
                    {
                        ItemID = c.String(nullable: false, maxLength: 10),
                        Description = c.String(maxLength: 200),
                        Tag = c.String(maxLength: 100),
                        OriginalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ItemID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bouquets");
        }
    }
}
