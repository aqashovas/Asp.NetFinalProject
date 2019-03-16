namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Counter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Counters", "PatientsCount", c => c.Int(nullable: false));
            AddColumn("dbo.Counters", "DoctorsCount", c => c.Int(nullable: false));
            AddColumn("dbo.Counters", "OperaOtionsCount", c => c.Int(nullable: false));
            DropColumn("dbo.Counters", "HappyPatiensCount");
            DropColumn("dbo.Counters", "ExperiencedDoctorsCount");
            DropColumn("dbo.Counters", "SuccessfulOperationsCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Counters", "SuccessfulOperationsCount", c => c.Int(nullable: false));
            AddColumn("dbo.Counters", "ExperiencedDoctorsCount", c => c.Int(nullable: false));
            AddColumn("dbo.Counters", "HappyPatiensCount", c => c.Int(nullable: false));
            DropColumn("dbo.Counters", "OperaOtionsCount");
            DropColumn("dbo.Counters", "DoctorsCount");
            DropColumn("dbo.Counters", "PatientsCount");
        }
    }
}
