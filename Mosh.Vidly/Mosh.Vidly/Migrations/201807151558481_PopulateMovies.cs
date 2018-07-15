namespace Mosh.Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Predator 1', 1)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Predator 2', 1)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Terminator 1', 1)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Terminator 2', 1)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Alien', 4)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Aliens', 1)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Alien 3', 2)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Alien: Ressurection', 1)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Emanuelle', 5)");
        }

        public override void Down()
        {
        }
    }
}
