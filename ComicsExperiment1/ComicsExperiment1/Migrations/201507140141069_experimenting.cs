namespace ComicsExperiment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class experimenting : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pages", "PageNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Pages", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pages", "Title");
            DropColumn("dbo.Pages", "PageNumber");
        }
    }
}
