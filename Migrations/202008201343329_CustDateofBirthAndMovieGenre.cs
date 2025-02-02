namespace MovieCustomerMVCWithAuthentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustDateofBirthAndMovieGenre : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DateOfBirth", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
