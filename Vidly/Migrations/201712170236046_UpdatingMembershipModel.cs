namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class UpdatingMembershipModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false, maxLength: 60));
        }

        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
