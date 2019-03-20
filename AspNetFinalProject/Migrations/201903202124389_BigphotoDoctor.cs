namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BigphotoDoctor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "BigPhoto", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doctors", "BigPhoto");
        }
    }
}
