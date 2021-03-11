using System;
using System.Data.Entity;
using ElbayanDatabase.DataClasses.Clints;
using ElbayanDatabase.DataClasses.Clints.Sales;
using ElbayanDatabase.DataClasses.Employees.CashierDrawers;
using ElbayanDatabase.DataClasses.Employees.EmployeeAccountant.EmployeeSalaryActions;
using ElbayanDatabase.DataClasses.Employees.EmployeeAccountant.Salary;
using ElbayanDatabase.DataClasses.Employees.Employees;
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
        //Employees
        public DbSet<CashierDrawer> CashierDrawers { get; set; }
        public DbSet<DailyOffShift> DailyOffShifts { get; set; }
        public DbSet<DrawerTransaction> DrawerTransactions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeePermission> EmployeePermissions { get; set; }
        public DbSet<Allowance> Allowances { get; set; }
        public DbSet<Commission> Commissions { get; set; }
        public DbSet<EmployeeSalary> EmployeeSalaries { get; set; }
        public DbSet<EmployeeSalaryAction> EmployeeSalaryActions { get; set; }
        public DbSet<DetectionsSalary> DetectionsSalaries { get; set; }
        public DbSet<IncreasesSalary> IncreasesSalaries { get; set; }
        public DbSet<Clint> Clints { get; set; }

        public DbSet<POS> Poses { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<DeferredPayment> DeferredPayments { get; set; }
        public DbSet<Building> Buildings { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasIndex(u => u.Email).IsUnique();

            modelBuilder.Entity<Role>()// Role : MemberRoles
                .HasMany(d => d.MemberRoles)
                .WithRequired(d => d.Role)
                .HasForeignKey(d => d.RoleId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Role>()// Role : EmployeePermissions
                .HasMany(d => d.EmployeePermissions)
                .WithRequired(d => d.Role)
                .HasForeignKey(d => d.RoleId)
                .WillCascadeOnDelete(false);
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
            modelBuilder.Entity<CashierDrawer>() //CashierDrawer : DailyOffShifts
                .HasMany(d => d.DailyOffShifts)
                .WithRequired(d => d.CashierDrawer)
                .HasForeignKey(d => d.CashierDrawerId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<CashierDrawer>()//CashierDrawer : DailyOffShifts
                .HasMany(d => d.DrawerTransactions)
                .WithRequired(d => d.CashierDrawer)
                .HasForeignKey(d => d.CashierDrawerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeSalaryAction>() //EmployeeSalaryAction : DetectionsSalaries
                .HasMany(d => d.DetectionsSalaries)
                .WithRequired(d => d.EmployeeSalaryAction)
                .HasForeignKey(d => d.ActionSalaryId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<EmployeeSalaryAction>()//EmployeeSalaryAction : IncreasesSalaries
                .HasMany(d => d.IncreasesSalaries)
                .WithRequired(d => d.EmployeeSalaryAction)
                .HasForeignKey(d => d.ActionSalaryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeSalary>() //EmployeeSalary : Allowances
                .HasMany(d => d.Allowances)
                .WithRequired(d => d.EmployeeSalary)
                .HasForeignKey(d => d.EmployeeSalaryId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<EmployeeSalary>()//EmployeeSalary : Commissions
                .HasMany(d => d.Commissions)
                .WithRequired(d => d.EmployeeSalary)
                .HasForeignKey(d => d.EmployeeSalaryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()// Employee : CashierDrawers
                .HasMany(d => d.CashierDrawers)
                .WithRequired(d => d.Employee)
                .HasForeignKey(d => d.EmployeeId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Employee>()// Employee : EmployeePermissions
                .HasMany(d => d.EmployeePermissions)
                .WithRequired(d => d.Employee)
                .HasForeignKey(d => d.EmployeeId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<Employee>()// Employee : EmployeeSalaries
                .HasMany(d => d.EmployeeSalaries)
                .WithRequired(d => d.Employee)
                .HasForeignKey(d => d.EmployeeId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<Employee>()// Employee : EmployeeSalaryActions
                .HasMany(d => d.EmployeeSalaryActions)
                .WithRequired(d => d.Employee)
                .HasForeignKey(d => d.EmployeeId)
                .WillCascadeOnDelete(true);
          
            modelBuilder.Entity<Clint>()
                .HasMany(d => d.Orders)
                .WithRequired(d => d.Clint)
                .HasForeignKey(d => d.ClintId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<POS>()
                .HasMany(d => d.Orders)
                .WithRequired(d => d.Pos)
                .HasForeignKey(d => d.PosId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Building>()
                .HasMany(d => d.Poses)
                .WithRequired(d => d.Building)
                .HasForeignKey(d => d.BuildingId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<Order>()
                .HasMany(d => d.DeferredPayments)
                .WithRequired(d => d.Order)
                .HasForeignKey(d => d.OrderId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Product>()
                .HasMany(d => d.OrderProducts)
                .WithRequired(d => d.Product)
                .HasForeignKey(d => d.ProductId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Order>()
                .HasMany(d => d.OrderProduct)
                .WithRequired(d => d.Order)
                .HasForeignKey(d => d.OrderId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Clint>()
                .HasMany(d=>d.Orders)
                .WithRequired(d=>d.Clint)
                .HasForeignKey(d=>d.ClintId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Clint>()
                .HasMany(d => d.Products)
                .WithRequired(d => d.Clint)
                .HasForeignKey(d => d.ClintId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Clint>()
                .HasMany(d => d.DeferredPayments)
                .WithRequired(d => d.Clint)
                .HasForeignKey(d => d.ClintId)
                .WillCascadeOnDelete(false);
        }
    }
}
