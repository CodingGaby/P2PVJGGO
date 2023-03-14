namespace P2PVJGGO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "TimeZone", c => c.String());
            DropColumn("dbo.Cities", "Landmark");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cities", "Landmark", c => c.String());
            DropColumn("dbo.Cities", "TimeZone");
        }
    }
}
