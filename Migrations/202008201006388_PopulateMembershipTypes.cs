namespace MovieCustomerMVCWithAuthentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into MembershipTypes(SignUpFree,DurationInMonth,DiscountRate) values(0,0,0)");
            Sql("Insert into MembershipTypes(SignUpFree,DurationInMonth,DiscountRate) values(30,1,10)");
            Sql("Insert into MembershipTypes(SignUpFree,DurationInMonth,DiscountRate) values(90,3,15)");
            Sql("Insert into MembershipTypes(SignUpFree,DurationInMonth,DiscountRate) values(300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
