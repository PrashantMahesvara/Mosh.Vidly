namespace Mosh.Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Drama')");
            Sql("INSERT INTO Genres (Name) VALUES ('Adventure')");
            Sql("INSERT INTO Genres (Name) VALUES ('Thriller')");
            Sql("INSERT INTO Genres (Name) VALUES ('Erotica')");
            Sql("INSERT INTO Genres (Name) VALUES ('Sleaze')");
            Sql("INSERT INTO Genres (Name) VALUES ('Horror')");
            Sql("INSERT INTO Genres (Name) VALUES ('Animated')");
            Sql("INSERT INTO Genres (Name) VALUES ('Family')");
            Sql("INSERT INTO Genres (Name) VALUES ('Documentary')");
            Sql("INSERT INTO Genres (Name) VALUES ('Science Fiction')");
            Sql("INSERT INTO Genres (Name) VALUES ('Fantasy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Ari Noire')");
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Romantic')");
            Sql("INSERT INTO Genres (Name) VALUES ('RomCom')");
            Sql("INSERT INTO Genres (Name) VALUES ('SitCom')");
        }
        
        public override void Down()
        {
        }
    }
}
