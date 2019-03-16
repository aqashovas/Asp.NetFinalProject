namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CounterUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Counters", "Name", c => c.String());
            AddColumn("dbo.Counters", "Logo", c => c.String());
            AddColumn("dbo.Counters", "Count", c => c.Int(nullable: false));
            DropColumn("dbo.Counters", "PatientsCount");
            DropColumn("dbo.Counters", "DoctorsCount");
            DropColumn("dbo.Counters", "OperaOtionsCount");
            DropColumn("dbo.Counters", "BedsCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Counters", "BedsCount", c => c.Int(nullable: false));
            AddColumn("dbo.Counters", "OperaOtionsCount", c => c.Int(nullable: false));
            AddColumn("dbo.Counters", "DoctorsCount", c => c.Int(nullable: false));
            AddColumn("dbo.Counters", "PatientsCount", c => c.Int(nullable: false));
            DropColumn("dbo.Counters", "Count");
            DropColumn("dbo.Counters", "Logo");
            DropColumn("dbo.Counters", "Name");
        }
    }
}
