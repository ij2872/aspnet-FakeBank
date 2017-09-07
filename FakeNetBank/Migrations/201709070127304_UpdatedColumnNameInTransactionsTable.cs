namespace FakeNetBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedColumnNameInTransactionsTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Transactions", new[] { "Customer_Id" });
            RenameColumn(table: "dbo.Transactions", name: "Customer_Id", newName: "customerId");
            AlterColumn("dbo.Transactions", "customerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Transactions", "customerId");
            AddForeignKey("dbo.Transactions", "customerId", "dbo.Customers", "Id", cascadeDelete: true);
            DropColumn("dbo.Transactions", "checkingAccountId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "checkingAccountId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Transactions", "customerId", "dbo.Customers");
            DropIndex("dbo.Transactions", new[] { "customerId" });
            AlterColumn("dbo.Transactions", "customerId", c => c.Int());
            RenameColumn(table: "dbo.Transactions", name: "customerId", newName: "Customer_Id");
            CreateIndex("dbo.Transactions", "Customer_Id");
            AddForeignKey("dbo.Transactions", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
