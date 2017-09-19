namespace FakeNetBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreatedOnToTransactionsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "CreatedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "CreatedOn");
        }
    }
}
