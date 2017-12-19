namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class UpdatingMembershipData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Membershiptypes SET Name = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE Membershiptypes SET Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE Membershiptypes SET Name = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE Membershiptypes SET Name = 'Annual' WHERE Id = 4");
        }

        public override void Down()
        {
        }
    }
}
