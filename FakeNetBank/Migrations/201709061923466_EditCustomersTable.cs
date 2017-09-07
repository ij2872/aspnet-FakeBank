namespace FakeNetBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers SET AccountNumber = '0000001234' WHERE Id = 1");
            Sql("Update Customers SET AccountNumber = '0000001235' WHERE Id = 2");
            Sql("Update Customers SET AccountNumber = '0000001236' WHERE Id = 3");

        }

        public override void Down()
        {
        }
    }
}
