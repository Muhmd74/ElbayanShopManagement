using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.DataClasses.Customers;
using ElbayanDatabase.DataClasses.Customers.Sales;
using ElbayanDatabase.DataClasses.Member;
using ElbayanDatabase.DataClasses.Product;
using ElbayanDatabase.DataClasses.Product.ProductCategory;
using ElbayanDatabase.DataClasses.Product.Unit;

namespace ElbayanDatabase.ConnectionTools
{
    public class ConnectionOption : DbContext
    {
        public ConnectionOption()
            : base(ConnectionString.Create())
        {

        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<MemberRole> MemberRoles { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<LargeUnit> LargeUnits { get; set; }
        public DbSet<SmallUnit> SmallUnits { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<ProductStock> ProductStocks { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<POS> Poses { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<DeferredPayment> DeferredPayments { get; set; }
        public DbSet<Building> Buildings { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()// Role : MemberRoles
                .HasMany(d => d.MemberRoles)
                .WithRequired(d => d.Role)
                .HasForeignKey(d => d.RoleId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<Member>()//Member : MemberRole
                .HasMany(d => d.MemberRoles)
                .WithRequired(d => d.Member)
                .HasForeignKey(d => d.MemberId)
                .WillCascadeOnDelete(true);
            //Product
            modelBuilder.Entity<Category>()//Category : SubCategory
                .HasMany(d => d.SubCategories)
                .WithRequired(d => d.Category)
                .HasForeignKey(d => d.CategoryId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<SubCategory>()//SubCategory Product
                .HasMany(d => d.Products)
                .WithRequired(d => d.SubCategory)
                .HasForeignKey(d => d.SubCategoryId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<LargeUnit>()//LargeUnit: Product
                .HasMany(d => d.Products)
                .WithRequired(d => d.LargeUnit)
                .HasForeignKey(d => d.LargeUnitId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<SmallUnit>() // SmallUnit : Product
                .HasMany(d => d.Products)
                .WithRequired(d => d.SmallUnit)
                .HasForeignKey(d => d.SmallUnitId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<LargeUnit>()// LargeUnit : SmallUnit 
                .HasMany(d => d.SmallUnits)
                .WithRequired(d => d.LargeUnit)
                .HasForeignKey(d => d.LargeUnitId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Category>()
                .Property(d => d.Id)
                .Equals(Guid.NewGuid());
            modelBuilder.Entity<Product>()//Product : ProductPrices
                .HasMany(d => d.ProductPrices)
                .WithRequired(d => d.Product)
                .HasForeignKey(d => d.ProductId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<Product>()//Product : ProductStocks
                .HasMany(d => d.ProductStocks)
                .WithRequired(d => d.Product)
                .HasForeignKey(d => d.ProductId)
                .WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CustomerType>()
                .HasMany(d=>d.Customers)
                .WithRequired(d=>d.CustomerType)
                .HasForeignKey(d=>d.CustomerTypeId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Customer>()
                .HasMany(d=>d.Orders)
                .WithRequired(d=>d.Customer)
                .HasForeignKey(d=>d.CustomerId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<POS>()
                .HasMany(d=>d.Orders)
                .WithRequired(d=>d.Pos)
                .HasForeignKey(d=>d.PosId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Building>()
                .HasMany(d=>d.Poses)
                .WithRequired(d=>d.Building)
                .HasForeignKey(d=>d.BuildingId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<Order>()
                .HasMany(d=>d.DeferredPayments)
                .WithRequired(d=>d.Order)
                .HasForeignKey(d=>d.OrderId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Product>()
                .HasMany(d=>d.OrderProducts)
                .WithRequired(d=>d.Product)
                .HasForeignKey(d=>d.ProductId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Order>()
                .HasMany(d=>d.OrderProducts)
                .WithRequired(d=>d.Order)
                .HasForeignKey(d=>d.OrderId)
                .WillCascadeOnDelete(false);
        }
    }
}
