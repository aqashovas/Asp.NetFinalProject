namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventHours : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Eventhours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Thepersonincharge = c.String(),
                        DayTime = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Departments", "HeadofDepartment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "HeadofDepartment");
            DropTable("dbo.Eventhours");
        }
    }
}
