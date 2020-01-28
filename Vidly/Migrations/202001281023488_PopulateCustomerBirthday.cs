namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerBirthday : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = '19810901' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
