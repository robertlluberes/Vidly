namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulatingGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) VALUES(1, 'Action')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(2, 'Adventure')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(3, 'Comedy')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(4, 'Drama')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(5, 'Epics / Historical')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(6, 'Musical / Dance')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(7, 'Science Fiction')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(8, 'War')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(9, 'Westerns')");

        }

        public override void Down()
        {
        }
    }
}
