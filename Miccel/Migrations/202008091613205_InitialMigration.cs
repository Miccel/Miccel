namespace Miccel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MemberShipTypes", "MemberShipType_Id", "dbo.MemberShipTypes");
            DropIndex("dbo.MemberShipTypes", new[] { "MemberShipType_Id" });
            DropColumn("dbo.MemberShipTypes", "DurationForYears");
            DropColumn("dbo.MemberShipTypes", "MemberShipType_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberShipTypes", "MemberShipType_Id", c => c.Byte());
            AddColumn("dbo.MemberShipTypes", "DurationForYears", c => c.Byte(nullable: false));
            CreateIndex("dbo.MemberShipTypes", "MemberShipType_Id");
            AddForeignKey("dbo.MemberShipTypes", "MemberShipType_Id", "dbo.MemberShipTypes", "Id");
        }
    }
}
