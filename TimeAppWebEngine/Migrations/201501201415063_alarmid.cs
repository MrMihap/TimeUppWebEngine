namespace TimeAppWebEngine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alarmid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stats", "AlarmId", c => c.Int());
            CreateIndex("dbo.Stats", "AlarmId");
            AddForeignKey("dbo.Stats", "AlarmId", "dbo.Tasks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stats", "AlarmId", "dbo.Tasks");
            DropIndex("dbo.Stats", new[] { "AlarmId" });
            DropColumn("dbo.Stats", "AlarmId");
        }
    }
}
