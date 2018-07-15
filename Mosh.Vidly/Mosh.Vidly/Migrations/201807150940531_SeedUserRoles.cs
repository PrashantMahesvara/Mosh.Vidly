namespace Mosh.Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUserRoles : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('da58b801-a6b6-40df-87c5-194c884122d8', '1')");
        }
        
        public override void Down()
        {
        }
    }
}
