namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpecialityExpertIn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Doctors", "Speciality");
            DropColumn("dbo.Doctors", "ExpertIn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "ExpertIn", c => c.String());
            AddColumn("dbo.Doctors", "Speciality", c => c.String());
        }
    }
}
