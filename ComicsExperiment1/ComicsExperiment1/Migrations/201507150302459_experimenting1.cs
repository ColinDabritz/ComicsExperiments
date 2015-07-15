namespace ComicsExperiment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class experimenting1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pages", "ImageUri", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pages", "ImageUri");
        }
    }
}
