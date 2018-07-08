namespace Mosh.Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AspNetRoles (Id, Name) VALUES ('1', 'Admin')");
            Sql("INSERT INTO AspNetRoles (Id, Name) VALUES ('2', 'User')");
            Sql("INSERT INTO AspNetUsers (Id, Email, EmailConfirmed, PasswordHash, SecurityStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEndDateUtc, LockoutEnabled, AccessFailedCount, UserName) VALUES ('da58b801-a6b6-40df-87c5-194c884122d8', 'lord_prashant@hotmail.com', '0', 'Pingvin', 'N/A', 'N/A', '0', '0', '', '', '', '0', '', 'Pengy')");
            Sql("INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('da58b801-a6b6-40df-87c5-194c884122d8', '1')");
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
