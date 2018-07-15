namespace Mosh.Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedAdmin : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AspNetRoles (Id, Name) VALUES ('1', 'Admin')");
            Sql("INSERT INTO AspNetRoles (Id, Name) VALUES ('2', 'User')");
        }

        public override void Down()
        {
        }
    }
}
