namespace Miccel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyCustomerTable2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MemberShipType_Id", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipType_Id" });
            AlterColumn("dbo.Customers", "MemberShipType_Id", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "MemberShipType_Id", c => c.Byte());
            CreateIndex("dbo.Customers", "MemberShipType_Id");
            AddForeignKey("dbo.Customers", "MemberShipType_Id", "dbo.MemberShipTypes", "Id");
        }
    }
}
