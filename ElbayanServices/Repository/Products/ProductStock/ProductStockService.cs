using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Common;
using ElbayanServices.Repository.Products.ProductStock.Dtos;

namespace ElbayanServices.Repository.Products.ProductStock
{
    public class ProductStockService : IProductStock, IDisposable
    {
        private readonly ConnectionOption _context;

        public ProductStockService(ConnectionOption context)
        {
            _context = context;
        }

        public bool CreateOpeningBalancesProduct(ProductStockDto model)
        {
            var productStock = _context.ProductStocks.Add(new ElbayanDatabase.DataClasses.Product.ProductStock
            {
                Stock = model.Stock,
                ProductId = model.ProductId
            });
            _context.SaveChanges();
            var productQuantity = _context.Products.FirstOrDefault(d => d.Id == model.ProductId);
            if (productQuantity != null)
            {
                productQuantity.TotalQuantity += model.Stock;
                _context.SaveChanges();
                return true;
            }

            return false;

        }

        public List<ProductStockDetails> GetAllProductStockDetails()
        {
            return _context.ProductStocks
                .Include(d => d.Product.LargeUnit)
                .Include(d => d.Product.SmallUnit)
                .Include(d => d.Order.Clint)
                .OrderByDescending(d => d.DateTime)
                .Select(d => new ProductStockDetails
                {
                    DateTime = d.Order.DateTime,
                    Quantity = d.Stock,
                    OrderNumber = d.Order.OrderNumber,
                    OrderType = d.Order.OrderType,
                    ProductName = d.Product.Name,
                    UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name,
                    UserName = d.Order.Clint.Name,
                    BarCode = d.Product.BarCode,
                    ProductNumber = d.Product.ProductNumber
                }).ToList();
        }

        public List<ProductStockDetails> GetAllProductStockDetailsByDateTime(DateTime firstDateTime, DateTime lastDateTime, string orderType)
        {
            return _context.ProductStocks
                .Include(d => d.Product.LargeUnit)
                .Include(d => d.Product.SmallUnit)
                .Include(d => d.Order.Clint)
                .OrderByDescending(d => d.DateTime)
                .Where(d => d.DateTime <= firstDateTime && d.DateTime <= lastDateTime || d.Order.OrderType == orderType)
                .Select(d => new ProductStockDetails
                {
                    DateTime = d.Order.DateTime,
                    Quantity = d.Stock,
                    OrderNumber = d.Order.OrderNumber,
                    OrderType = d.Order.OrderType,
                    ProductName = d.Product.Name,
                    UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name,
                    UserName = d.Order.Clint.Name,
                    BarCode = d.Product.BarCode,
                    ProductNumber = d.Product.ProductNumber
                }).ToList();
        }

        public List<ProductStockDetails> GetAllProductStockDetailsByType(string orderType)
        {
            return _context.ProductStocks
                .Include(d => d.Product.LargeUnit)
                .Include(d => d.Product.SmallUnit)
                .Include(d => d.Order.Clint)
                .OrderByDescending(d => d.DateTime)
                .Where(d => d.Order.OrderType == orderType)
                .Select(d => new ProductStockDetails
                {
                    DateTime = d.Order.DateTime,
                    Quantity = d.Stock,
                    OrderNumber = d.Order.OrderNumber,
                    OrderType = d.Order.OrderType,
                    ProductName = d.Product.Name,
                    UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name,
                    UserName = d.Order.Clint.Name,
                    BarCode = d.Product.BarCode,
                    ProductNumber = d.Product.ProductNumber
                }).ToList();
        }

        public List<ProductStockDetails> GetAllProductStockDetailsSearch(string productName, long barCode)
        {
            return _context.ProductStocks
                .Include(d => d.Product.LargeUnit)
                .Include(d => d.Product.SmallUnit)
                .Include(d => d.Order.Clint)
                .OrderByDescending(d => d.DateTime)
                .Where(d => d.Product.Name.Contains(productName) || d.Product.BarCode.ToString().Contains(barCode.ToString()))
                .Select(d => new ProductStockDetails
                {
                    DateTime = d.Order.DateTime,
                    Quantity = d.Stock,
                    OrderNumber = d.Order.OrderNumber,
                    OrderType = d.Order.OrderType,
                    ProductName = d.Product.Name,
                    UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name,
                    UserName = d.Order.Clint.Name,
                    BarCode = d.Product.BarCode,
                    ProductNumber = d.Product.ProductNumber
                }).ToList();
        }


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
