namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "PosId", "dbo.POS");
            DropForeignKey("dbo.CashierDrawers", "PosId", "dbo.POS");
            DropForeignKey("dbo.DeferredPayments", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderProducts", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Customers", "CustomerTypeId", "dbo.CustomerTypes");
            DropForeignKey("dbo.Suppliers", "CustomerTypeId", "dbo.CustomerTypes");
            DropForeignKey("dbo.SupplierDeferredPayments", "SupplierOrderId", "dbo.SupplierOrders");
            DropForeignKey("dbo.SupplierOrderProducts", "SupplierOrderId", "dbo.SupplierOrders");
            DropPrimaryKey("dbo.POS");
            DropPrimaryKey("dbo.Orders");
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.CustomerTypes");
            DropPrimaryKey("dbo.SupplierOrders");
            DropPrimaryKey("dbo.SupplierOrderProducts");
            DropPrimaryKey("dbo.OrderProducts");
            DropPrimaryKey("dbo.DeferredPayments");
            AlterColumn("dbo.POS", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Orders", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Customers", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.CustomerTypes", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.SupplierOrders", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.SupplierOrderProducts", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.OrderProducts", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.DeferredPayments", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.POS", "Id");
            AddPrimaryKey("dbo.Orders", "Id");
            AddPrimaryKey("dbo.Customers", "Id");
            AddPrimaryKey("dbo.CustomerTypes", "Id");
            AddPrimaryKey("dbo.SupplierOrders", "Id");
            AddPrimaryKey("dbo.SupplierOrderProducts", "Id");
            AddPrimaryKey("dbo.OrderProducts", "Id");
            AddPrimaryKey("dbo.DeferredPayments", "Id");
            AddForeignKey("dbo.Orders", "PosId", "dbo.POS", "Id");
            AddForeignKey("dbo.CashierDrawers", "PosId", "dbo.POS", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DeferredPayments", "OrderId", "dbo.Orders", "Id");
            AddForeignKey("dbo.OrderProducts", "OrderId", "dbo.Orders", "Id");
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "Id");
            AddForeignKey("dbo.Customers", "CustomerTypeId", "dbo.CustomerTypes", "Id");
            AddForeignKey("dbo.Suppliers", "CustomerTypeId", "dbo.CustomerTypes", "Id");
            AddForeignKey("dbo.SupplierDeferredPayments", "SupplierOrderId", "dbo.SupplierOrders", "Id");
            AddForeignKey("dbo.SupplierOrderProducts", "SupplierOrderId", "dbo.SupplierOrders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplierOrderProducts", "SupplierOrderId", "dbo.SupplierOrders");
            DropForeignKey("dbo.SupplierDeferredPayments", "SupplierOrderId", "dbo.SupplierOrders");
            DropForeignKey("dbo.Suppliers", "CustomerTypeId", "dbo.CustomerTypes");
            DropForeignKey("dbo.Customers", "CustomerTypeId", "dbo.CustomerTypes");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.OrderProducts", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.DeferredPayments", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.CashierDrawers", "PosId", "dbo.POS");
            DropForeignKey("dbo.Orders", "PosId", "dbo.POS");
            DropPrimaryKey("dbo.DeferredPayments");
            DropPrimaryKey("dbo.OrderProducts");
            DropPrimaryKey("dbo.SupplierOrderProducts");
            DropPrimaryKey("dbo.SupplierOrders");
            DropPrimaryKey("dbo.CustomerTypes");
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.Orders");
            DropPrimaryKey("dbo.POS");
            AlterColumn("dbo.DeferredPayments", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.OrderProducts", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.SupplierOrderProducts", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.SupplierOrders", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.CustomerTypes", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Customers", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Orders", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.POS", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.DeferredPayments", "Id");
            AddPrimaryKey("dbo.OrderProducts", "Id");
            AddPrimaryKey("dbo.SupplierOrderProducts", "Id");
            AddPrimaryKey("dbo.SupplierOrders", "Id");
            AddPrimaryKey("dbo.CustomerTypes", "Id");
            AddPrimaryKey("dbo.Customers", "Id");
            AddPrimaryKey("dbo.Orders", "Id");
            AddPrimaryKey("dbo.POS", "Id");
            AddForeignKey("dbo.SupplierOrderProducts", "SupplierOrderId", "dbo.SupplierOrders", "Id");
            AddForeignKey("dbo.SupplierDeferredPayments", "SupplierOrderId", "dbo.SupplierOrders", "Id");
            AddForeignKey("dbo.Suppliers", "CustomerTypeId", "dbo.CustomerTypes", "Id");
            AddForeignKey("dbo.Customers", "CustomerTypeId", "dbo.CustomerTypes", "Id");
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "Id");
            AddForeignKey("dbo.OrderProducts", "OrderId", "dbo.Orders", "Id");
            AddForeignKey("dbo.DeferredPayments", "OrderId", "dbo.Orders", "Id");
            AddForeignKey("dbo.CashierDrawers", "PosId", "dbo.POS", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "PosId", "dbo.POS", "Id");
        }
    }
}
