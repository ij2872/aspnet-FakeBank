namespace FakeNetBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAccountNumberToVarcharInCustomersTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "AccountNumber", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "AccountNumber", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
