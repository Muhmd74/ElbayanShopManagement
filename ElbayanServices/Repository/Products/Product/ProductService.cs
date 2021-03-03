using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Common;
using ElbayanServices.Repository.Products.Product.Dtos;
using ElbayanServices.Repository.Products.SubCategory.Dtos;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;

namespace ElbayanServices.Repository.Products.Product
{
    public class ProductService : IProduct, IDisposable
    {
        private readonly ConnectionOption _context;


        public ProductService(ConnectionOption context)
        {
            _context = context;
        }

       
        public bool Add(ProductDto model)
        {

                var result = _context.Products.Add(new ElbayanDatabase.DataClasses.Product.Product
                {
                    Description = model.Description,
                    Name = model.Name,
                    BarCode = GenerateSequenceNumber(),
                    PurchaseDefaultPrice = model.PurchaseDefaultPrice,
                    IsExpired = model.IsExpired,
                    LargeUnitId = model.LargeUnitId,
                    LimitedDemand = model.LimitedDemand,
                    ProductNumber = GenerateProductNumber(),
                    SmallUnitId = model.SmallUnitId,
                    SubCategoryId = model.SubCategoryId,
                    UCP = model.UCP,
                    IsDeleted = false,
                    DateTime = DateTime.UtcNow,
                    SaleDefaultPrice = model.SaleDefaultPrice,
                    WholesalePrice = model.WholesalePrice,
                    IsUnitSale = model.IsUnitSale,
                    ImageUrl = model.ImageUrl,
                    Discount = Convert.ToInt32(model.Discount),
                    Vat = Convert.ToInt32(model.Vat)
                });
                _context.SaveChanges();
                return true;
        }

        public bool Update(ProductDto model)
        {

                var result = _context.Products.FirstOrDefault(d => d.Id == model.Id);
                if (result == null) return false;
                result.Description = model.Description;
                result.Name = model.Name;
                result.BarCode = Convert.ToInt32(model.BarCode);
                result.PurchaseDefaultPrice = model.PurchaseDefaultPrice;
                result.SaleDefaultPrice = model.SaleDefaultPrice;
                result.WholesalePrice = model.WholesalePrice;
                result.LargeUnitId = model.LargeUnitId;
                result.SmallUnitId = model.SmallUnitId;
                result.LimitedDemand = model.LimitedDemand;
                result.SubCategoryId = model.SubCategoryId;
                result.UCP = model.UCP;
                _context.SaveChanges();
                return true;
        }

        public List<SmallUnitNameDto> GetAllSmallUnitByLargeUnit(Guid largeUnitId)
        {
            var model = _context.SmallUnits.
                Where(d => d.LargeUnitId == largeUnitId
                           && d.IsDeleted == false)
                .Select(d => new SmallUnitNameDto()
                {
                    SmallUnitId = d.Id,
                    Name = d.Name
                }).ToList();
           

            return model;
        }

        public List<SmallUnitNameDto> GetAllSmallUnit()
        {
            var model = _context.SmallUnits.
                Where(d =>d.IsDeleted == false)
                .Select(d => new SmallUnitNameDto()
                {
                    SmallUnitId = d.Id,
                    Name = d.Name
                }).ToList();
            return model;
        }

        public List<SubCategoryNameDto> GetAllSubCategory()
        {
            var model = _context.SubCategories.
                Where(d => d.IsDeleted == false&&d.Category.IsDeleted==false)
                .Select(d => new SubCategoryNameDto()
                {
                    Id = d.Id,
                    Name = d.Name
                }).ToList();
            return model;
        }

        public List<LargeUnitNameDto> GetAllLargeUnit()
        {
            var model = _context.LargeUnits.
                Where(d => d.IsDeleted == false)
                .Select(d => new LargeUnitNameDto()
                {
                    LargeUnitId = d.Id,
                    Name = d.Name
                }).ToList();


                return model;

        }

        public bool IsDeleted(Guid id)
        {
            var model = _context.Products.FirstOrDefault(d => d.Id == id);
            if (model != null)
            {
                model.IsDeleted = !model.IsDeleted;
                _context.SaveChanges();
                return true;
            }

            return false;
        }
        public bool MainSalesUnit(Guid id)
        {
            var model = _context.Products.FirstOrDefault(d => d.Id == id);
            if (model != null)
            {
                model.IsUnitSale = !model.IsUnitSale;
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<ProductDto> GetAllProductDeleted()
        {
            return _context.Products.Where(d => d.IsDeleted)
                .Include(d => d.SmallUnit)
                .Include(d => d.LargeUnit)
                .Include(d => d.SubCategory)
                .OrderByDescending(d => d.DateTime)
                .Select(d => new ProductDto()
                {
                    Description = d.Description,
                    Name = d.Name,
                    BarCode = d.BarCode,
                    PurchaseDefaultPrice = d.PurchaseDefaultPrice,
                    IsExpired = d.IsExpired,
                    LargeUnitId = d.LargeUnitId,
                    LimitedDemand = d.LimitedDemand,
                    ProductNumber = d.ProductNumber,
                    SmallUnitId = d.SmallUnitId,
                    SubCategoryId = d.SubCategoryId,
                    UCP = d.UCP,
                    Id = d.Id,
                    SmallUnitName = d.SmallUnit.Name,
                    LargeUnitName = d.LargeUnit.Name,
                    SubCategoryName = d.SubCategory.Name,
                    SaleDefaultPrice = d.SaleDefaultPrice,
                    WholesalePrice = d.WholesalePrice,
                    ImageUrl = d.ImageUrl,
                    IsMAinSalesUnit = d.IsUnitSale ? d.LargeUnit.Name : d.SmallUnit.Name

                }).ToList();
        }

        public List<ProductDto> GetAll()
        {
            return _context.Products.Where(d => d.IsDeleted == false)
                .Include(d => d.SmallUnit)
                .Include(d => d.LargeUnit)
                .Include(d => d.SubCategory)
                .OrderByDescending(d => d.DateTime)
                .Select(d => new ProductDto()
                {
                    Id = d.Id,
                    Description = d.Description,
                    Name = d.Name,
                    BarCode = d.BarCode,
                    PurchaseDefaultPrice = d.PurchaseDefaultPrice,
                    IsExpired = d.IsExpired,
                    LargeUnitId = d.LargeUnitId,
                    LimitedDemand = d.LimitedDemand,
                    ProductNumber = d.ProductNumber,
                    SmallUnitId = d.SmallUnitId,
                    SubCategoryId = d.SubCategoryId,
                    UCP = d.UCP,
                    SmallUnitName = d.SmallUnit.Name,
                    LargeUnitName = d.LargeUnit.Name,
                    SubCategoryName = d.SubCategory.Name,
                    SaleDefaultPrice = d.SaleDefaultPrice,
                    WholesalePrice = d.WholesalePrice,
                    Discount = d.Discount,
                    Vat = d.Vat,
                    ImageUrl = d.ImageUrl,
                    IsUnitSale = d.IsUnitSale,
                    IsMAinSalesUnit = d.IsUnitSale ? d.LargeUnit.Name : d.SmallUnit.Name
                }).ToList();
           
        }

        public List<ProductDto> GetAllByCategory(Guid categoryId)
        {
            return _context.Products
                .Where(d =>d.SubCategoryId==categoryId 
                           &&d.IsDeleted == false)
                .Include(d => d.SmallUnit)
                .Include(d => d.LargeUnit)
                .Include(d => d.SubCategory)
                .OrderByDescending(d => d.DateTime)
                .Select(d => new ProductDto()
                {
                    Description = d.Description,
                    Name = d.Name,
                    BarCode = d.BarCode,
                    PurchaseDefaultPrice = d.PurchaseDefaultPrice,
                    IsExpired = d.IsExpired,
                    LargeUnitId = d.LargeUnitId,
                    LimitedDemand = d.LimitedDemand,
                    ProductNumber = d.ProductNumber,
                    SmallUnitId = d.SmallUnitId,
                    SubCategoryId = d.SubCategoryId,
                    UCP = d.UCP,
                    Id = d.Id,
                    SmallUnitName = d.SmallUnit.Name,
                    LargeUnitName = d.LargeUnit.Name,
                    SubCategoryName = d.SubCategory.Name,
                    WholesalePrice = d.WholesalePrice,
                    SaleDefaultPrice = d.SaleDefaultPrice,
                    IsMAinSalesUnit = d.IsUnitSale ? d.LargeUnit.Name : d.SmallUnit.Name
                }).ToList();
         }

        public ProductDto GetById(Guid id)
        {
            var model = _context.Products
                .Include(d => d.SmallUnit)
                .Include(d => d.LargeUnit)
                .Include(d => d.SubCategory)
                .FirstOrDefault(d => d.Id == id);
            if (model != null)
            {
                return new ProductDto()
                {
                    Description = model.Description,
                    Name = model.Name,
                    BarCode = model.BarCode,
                    PurchaseDefaultPrice = model.PurchaseDefaultPrice,
                    IsExpired = model.IsExpired,
                    LargeUnitName = model.LargeUnit.Name,
                    LargeUnitId = model.LargeUnitId,
                    Id = model.Id,
                    LimitedDemand = model.LimitedDemand,
                    ProductNumber = model.ProductNumber,
                    SmallUnitId = model.SmallUnitId,
                    SmallUnitName = model.SmallUnit.Name,
                    SubCategoryId = model.SubCategoryId,
                    SubCategoryName = model.SubCategory.Name,
                    UCP = model.UCP,
                    WholesalePrice = model.WholesalePrice,
                    SaleDefaultPrice = model.SaleDefaultPrice,
                    IsMAinSalesUnit = model.IsUnitSale ? model.LargeUnit.Name : model.SmallUnit.Name
                };
            }

            return null;
        }

        public ProductDto GetByName(string productName)
        {

            var model = _context.Products
                .Include(d => d.SmallUnit)
                .Include(d => d.LargeUnit)
                .Include(d => d.SubCategory)
                .FirstOrDefault(d => d.Name == productName&&d.IsDeleted==false);
            if (model != null)
            {
                return new ProductDto()
                {
                    Description = model.Description,
                    Name = model.Name,
                    BarCode = model.BarCode,
                    IsExpired = model.IsExpired,
                    LargeUnitName = model.LargeUnit.Name,
                    LargeUnitId = model.LargeUnitId,
                    Id = model.Id,
                    LimitedDemand = model.LimitedDemand,
                    ProductNumber = model.ProductNumber,
                    SmallUnitId = model.SmallUnitId,
                    SmallUnitName = model.SmallUnit.Name,
                    SubCategoryId = model.SubCategoryId,
                    SubCategoryName = model.SubCategory.Name,
                    UCP = model.UCP
                };
            }

            return null;
        }


        public List<ProductNameDto> GetAllProductName()
        {
            var model = _context.Products.Where(d => d.IsDeleted == false)
                .Select(d => new ProductNameDto()
                {
                    ProductId = d.Id,
                    ProductName = d.Name
                }).ToList();
         

            return model;
        }
        public long GeneratorRandomNumber()
        {
            while (true)
            {
                var number = new Random().NextLong(1, 1000000);
                if (!_context.Products.Any(d => d.ProductNumber == number))
                {
                    return number;
                }
            }
        }
        public int GenerateProductNumber()
        {
            var lastNumber = _context.Products.OrderByDescending(d => d.DateTime).LastOrDefault()?.ProductNumber;
            if (lastNumber >= 0)
            {
                return (int)(lastNumber + 1);
            }

            return 01;
        }
        public long GenerateSequenceNumber()
        {
            var lastNumber = _context.Products.OrderByDescending(d => d.DateTime).LastOrDefault()?.BarCode;
            if (lastNumber >= 0)
            {
                return (long)(lastNumber + 1);
            }

            return 0001131;
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
