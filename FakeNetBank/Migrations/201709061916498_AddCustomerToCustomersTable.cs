namespace FakeNetBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerToCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (AccountNumber, FirstName, LastName, Balance) VALUES ('0000001234', 'ivan', 'jaimes', 100000.00)");
            Sql("INSERT INTO Customers (AccountNumber, FirstName, LastName, Balance) VALUES ('0000001235', 'john', 'smith', 100000.00)");
            Sql("INSERT INTO Customers (AccountNumber, FirstName, LastName, Balance) VALUES ('0000001236', 'burt', 'bjergsen', 100000.00)");
        }
        
        public override void Down()
        {
        }
    }
}
