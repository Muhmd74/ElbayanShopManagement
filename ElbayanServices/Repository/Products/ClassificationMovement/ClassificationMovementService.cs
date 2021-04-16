using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.ClassificationMovement.Dtos;

namespace ElbayanServices.Repository.Products.ClassificationMovement
{
    public class ClassificationMovementService : IClassificationMovement, IDisposable
    {
        private readonly ConnectionOption _context;

        public ClassificationMovementService(ConnectionOption context)
        {
            _context = context;
        }

        public List<ClassificationMovementDto> GetAllClassificationMovement()
        {
            return _context.ProductStocks
                .Include(d => d.Order.Clint)
                .Include(d => d.Product.SubCategory.Category)
                .Include(d => d.Product.LargeUnit)
                .Include(d => d.Product.SmallUnit)
                .OrderByDescending(d => d.DateTime)
                .Select(d => new ClassificationMovementDto()
                {
                    DateTime = d.DateTime,
                    BarCode = d.Product.BarCode,
                    OrderNumber = d.Order.OrderNumber,
                    OrderType = d.Order.OrderType,
                    StockStatues = d.StockStatues,
                    QuantityInStore = d.Stock,
                    ProductNumber = d.Product.ProductNumber,
                    CategoryName = d.Product.SubCategory.Category.Name,
                    ProductName = d.Product.Name,
                    SubCategoryName = d.Product.SubCategory.Name,
                    UserName = d.Order.Clint.Name,
                    UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name

                }).ToList();
        }

        public List<ClassificationMovementDto> FilterClassificationMoreSale()
        {
            return _context.ProductStocks
                .Include(d => d.Order.Clint)
                .Include(d => d.Product.SubCategory.Category)
                .Include(d => d.Product.LargeUnit)
                .Include(d => d.Product.SmallUnit)
                .OrderByDescending(d => d.Order.OrderProduct.Max(a => a.Quantity))
                .Select(d => new ClassificationMovementDto()
                {
                    DateTime = d.DateTime,
                    BarCode = d.Product.BarCode,
                    OrderNumber = d.Order.OrderNumber,
                    OrderType = d.Order.OrderType,
                    StockStatues = d.StockStatues,
                    QuantityInStore = d.Stock,
                    ProductNumber = d.Product.ProductNumber,
                    CategoryName = d.Product.SubCategory.Category.Name,
                    ProductName = d.Product.Name,
                    SubCategoryName = d.Product.SubCategory.Name,
                    UserName = d.Order.Clint.Name,
                    UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name

                }).ToList();
        }

        public List<ClassificationMovementDto> FilterClassificationLessSale()
        {
            return _context.ProductStocks
                .Include(d => d.Order.Clint)
                .Include(d => d.Product.SubCategory.Category)
                .Include(d => d.Product.LargeUnit)
                .Include(d => d.Product.SmallUnit)
                .OrderByDescending(d => d.Order.OrderProduct.Min(a => a.Quantity))
                .Select(d => new ClassificationMovementDto()
                {
                    DateTime = d.DateTime,
                    BarCode = d.Product.BarCode,
                    OrderNumber = d.Order.OrderNumber,
                    OrderType = d.Order.OrderType,
                    StockStatues = d.StockStatues,
                    QuantityInStore = d.Stock,
                    ProductNumber = d.Product.ProductNumber,
                    CategoryName = d.Product.SubCategory.Category.Name,
                    ProductName = d.Product.Name,
                    SubCategoryName = d.Product.SubCategory.Name,
                    UserName = d.Order.Clint.Name,
                    UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name

                }).ToList();
        }

        public List<ClassificationMovementDto> GetClassificationByCategoryAndSubCategory(Guid subCategoryId, Guid? categoryId)
        {
            return _context.ProductStocks
                .Include(d => d.Order.Clint)
                .Include(d => d.Product.SubCategory.Category)
                .Include(d => d.Product.LargeUnit)
                .Include(d => d.Product.SmallUnit)
                .Where(d => d.Product.SubCategoryId == subCategoryId || d.Product.SubCategory.CategoryId == categoryId)
                .OrderByDescending(d => d.DateTime)
                .Select(d => new ClassificationMovementDto()
                {
                    DateTime = d.DateTime,
                    BarCode = d.Product.BarCode,
                    OrderNumber = d.Order.OrderNumber,
                    OrderType = d.Order.OrderType,
                    StockStatues = d.StockStatues,
                    QuantityInStore = d.Stock,
                    ProductNumber = d.Product.ProductNumber,
                    CategoryName = d.Product.SubCategory.Category.Name,
                    ProductName = d.Product.Name,
                    SubCategoryName = d.Product.SubCategory.Name,
                    UserName = d.Order.Clint.Name,
                    UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name

                }).ToList();
        }

        public List<ClassificationMovementDto> GetClassificationByDateTime(DateTime? firstDateTime, DateTime? lastDateTime, string orderType, Guid? productId, Guid? subCategoryId, Guid? categoryId)
        {
            return _context.ProductStocks
                .Include(d => d.Order.Clint)
                .Include(d => d.Product.SubCategory.Category)
                .Include(d => d.Product.LargeUnit)
                .Include(d => d.Product.SmallUnit)
                .Where(d =>
                    d.DateTime >= firstDateTime
                    || d.DateTime <= lastDateTime
                    || d.ProductId == productId
                    || d.Order.OrderType == orderType
                    || d.Product.SubCategoryId == subCategoryId
                    || d.Product.SubCategory.CategoryId == categoryId

                    )
                .OrderByDescending(d => d.DateTime)
                .Select(d => new ClassificationMovementDto()
                {
                    DateTime = d.DateTime,
                    BarCode = d.Product.BarCode,
                    OrderNumber = d.Order.OrderNumber,
                    OrderType = d.Order.OrderType,
                    StockStatues = d.StockStatues,
                    QuantityInStore = d.Stock,
                    ProductNumber = d.Product.ProductNumber,
                    CategoryName = d.Product.SubCategory.Category.Name,
                    ProductName = d.Product.Name,
                    SubCategoryName = d.Product.SubCategory.Name,
                    UserName = d.Order.Clint.Name,
                    UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name

                }).ToList();
        }

        public List<ClassificationMovementDto> GetClassificationSearch(string productName, long? barCode)
        {
            return _context.ProductStocks
                .Include(d => d.Order.Clint)
                .Include(d => d.Product.SubCategory.Category)
                .Include(d => d.Product.LargeUnit)
                .Include(d => d.Product.SmallUnit)
                .Where(d => d.Product.Name.Contains(productName) || d.Product.BarCode.ToString().Contains(barCode.ToString()))
                .OrderByDescending(d => d.DateTime)
                .Select(d => new ClassificationMovementDto()
                {
                    DateTime = d.DateTime,
                    BarCode = d.Product.BarCode,
                    OrderNumber = d.Order.OrderNumber,
                    OrderType = d.Order.OrderType,
                    StockStatues = d.StockStatues,
                    QuantityInStore = d.Stock,
                    ProductNumber = d.Product.ProductNumber,
                    CategoryName = d.Product.SubCategory.Category.Name,
                    ProductName = d.Product.Name,
                    SubCategoryName = d.Product.SubCategory.Name,
                    UserName = d.Order.Clint.Name,
                    UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name

                }).ToList();
        }

        public List<ClassificationMovementDto> GetAllProductStockDetailsByType(string orderType)
        {
            return _context.ProductStocks
                .Include(d => d.Order.Clint)
                .Include(d => d.Product.SubCategory.Category)
                .Include(d => d.Product.LargeUnit)
                .Include(d => d.Product.SmallUnit)
                .Where(d => d.Order.OrderType == orderType)
                .OrderByDescending(d => d.DateTime)
                .Select(d => new ClassificationMovementDto()
                {
                    DateTime = d.DateTime,
                    BarCode = d.Product.BarCode,
                    OrderNumber = d.Order.OrderNumber,
                    OrderType = d.Order.OrderType,
                    StockStatues = d.StockStatues,
                    QuantityInStore = d.Stock,
                    ProductNumber = d.Product.ProductNumber,
                    CategoryName = d.Product.SubCategory.Category.Name,
                    ProductName = d.Product.Name,
                    SubCategoryName = d.Product.SubCategory.Name,
                    UserName = d.Order.Clint.Name,
                    UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name

                }).ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
