namespace Mosh.Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AspNetUsers (Id, Email, EmailConfirmed, PasswordHash, SecurityStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEndDateUtc, LockoutEnabled, AccessFailedCount, UserName) VALUES ('da58b801-a6b6-40df-87c5-194c884122d8', 'lord_prashant@hotmail.com', '1', 'Pingvin', null, null, '0', '0',  null, '0', '0', 'Pengy')");
        }
        
        public override void Down()
        {
        }
    }
}
