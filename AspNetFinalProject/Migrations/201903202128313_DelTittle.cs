namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DelTittle : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Doctors", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "Title", c => c.String());
        }
    }
}
