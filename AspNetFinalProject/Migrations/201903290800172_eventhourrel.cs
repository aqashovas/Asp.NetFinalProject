namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventhourrel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Eventhours", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Eventhours", "DepartmentId");
            AddForeignKey("dbo.Eventhours", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Eventhours", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Eventhours", new[] { "DepartmentId" });
            DropColumn("dbo.Eventhours", "DepartmentId");
        }
    }
}
