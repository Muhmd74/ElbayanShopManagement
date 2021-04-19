using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.ProductPrice.Dto;

namespace ElbayanServices.Repository.Products.ProductPrice
{
    public class ProductPriceService : IProductPrice, IDisposable
    {
        private readonly ConnectionOption _context;

        public ProductPriceService(ConnectionOption context)
        {
            _context = context;
        }

        public List<MovementProductPriceDto> GetAllProductPrice()
        {
            try
            {
                return _context.ProductPrices
                    .Include(d => d.Product.LargeUnit)
                    .Include(d => d.Product.SmallUnit)
                    .OrderByDescending(d => d.DateTime)
                    .Select(d => new MovementProductPriceDto()
                    {
                        BarCode = d.Product.BarCode,
                        DateTime = d.DateTime,
                        Discount = d.Discount,
                        PriceSale = d.ProcPrice,
                        SaleDefaultPrice = d.Product.SaleDefaultPrice,
                        ProductNumber = d.Product.ProductNumber,
                        ProductName = d.Product.Name,
                        ProcessType = d.ProcessType,
                        Vat = d.Product.Vat,
                        UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name,

                    }).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public List<MovementProductPriceDto> GetAllProductPriceByDateTime(DateTime? firstDateTime, DateTime? lastDateTime, string processType, Guid? productId)
        {
            try
            {
                return _context.ProductPrices
                    .Include(d => d.Product.LargeUnit)
                    .Include(d => d.Product.SmallUnit)
                    .OrderByDescending(d => d.DateTime)
                    .Where(d => d.DateTime >= firstDateTime || d.DateTime <= lastDateTime
                                                            || d.ProcessType == processType
                                                            || d.ProductId == productId
                    )
                    .Select(d => new MovementProductPriceDto()
                    {
                        BarCode = d.Product.BarCode,
                        DateTime = d.DateTime,
                        Discount = d.Discount,
                        PriceSale = d.ProcPrice,
                        SaleDefaultPrice = d.Product.SaleDefaultPrice,
                        ProductNumber = d.Product.ProductNumber,
                        ProductName = d.Product.Name,
                        ProcessType = d.ProcessType,
                        Vat = d.Product.Vat,
                        UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name,

                    }).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public List<MovementProductPriceDto> GetAllProductPriceByType(string processType)
        {
            try
            {
                return _context.ProductPrices
                    .Include(d => d.Product.LargeUnit)
                    .Include(d => d.Product.SmallUnit)
                    .OrderByDescending(d => d.DateTime)
                    .Where(d =>d.ProcessType == processType
                    )
                    .Select(d => new MovementProductPriceDto()
                    {
                        BarCode = d.Product.BarCode,
                        DateTime = d.DateTime,
                        Discount = d.Discount,
                        PriceSale = d.ProcPrice,
                        SaleDefaultPrice = d.Product.SaleDefaultPrice,
                        ProductNumber = d.Product.ProductNumber,
                        ProductName = d.Product.Name,
                        ProcessType = d.ProcessType,
                        Vat = d.Product.Vat,
                        UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name,

                    }).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public List<MovementProductPriceDto> GetAllProductPriceSearch(string productName, long? barCode)
        {
            try
            {
                return _context.ProductPrices
                    .Include(d => d.Product.LargeUnit)
                    .Include(d => d.Product.SmallUnit)
                    .OrderByDescending(d => d.DateTime)
                    .Where(d => d.Product.Name.Contains(productName)
                                || d.Product.BarCode.ToString().Contains(barCode.ToString())
                    )
                    .Select(d => new MovementProductPriceDto()
                    {
                        BarCode = d.Product.BarCode,
                        DateTime = d.DateTime,
                        Discount = d.Discount,
                        PriceSale = d.ProcPrice,
                        SaleDefaultPrice = d.Product.SaleDefaultPrice,
                        ProductNumber = d.Product.ProductNumber,
                        ProductName = d.Product.Name,
                        ProcessType = d.ProcessType,
                        Vat = d.Product.Vat,
                        UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name,

                    }).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
