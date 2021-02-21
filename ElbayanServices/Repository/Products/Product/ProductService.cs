﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Common;
using ElbayanServices.Repository.Products.Product.Dtos;
using ElbayanServices.Repository.Products.Product.Validators;
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

                var result = _context.Products.Add(new ElbayanDatabase.DataClasses.Product.Product()
                {
                    Description = model.Description,
                    Name = model.Name,
                    BarCode = model.BarCode,
                    PurchaseDefaultPrice = model.PurchaseDefaultPrice,
                    IsExpired = model.IsExpired,
                    LargeUnitId = model.LargeUnitId,
                    LimitedDemand = model.LimitedDemand,
                    ProductNumber = GeneratorRandomNumber(),
                    SmallUnitId = model.SmallUnitId,
                    SubCategoryId = model.SubCategoryId,
                    UCP = model.UCP,
                    IsDeleted = false,
                    DateTime = DateTime.UtcNow,
                    SaleDefaultPrice = model.SaleDefaultPrice,
                    WholesalePrice = model.WholesalePrice
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
                result.BarCode = model.BarCode;
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
            if (model.Any())
            {
                return model;
            }

            return null;
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
            if (model.Any())
            {
                return model;
            }

            return null;
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

            if (model.Any())
            {
                return model;
            }

            return null;
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
            var Products = _context.Products.Where(d => d.IsDeleted)
                .Include(d => d.SmallUnit)
                .Include(d => d.LargeUnit)
                .Include(d => d.SubCategory)
                .OrderByDescending(d => d.DateTime)
                .Select(d => new ProductDto()
                {
                    Description = d.Description,
                    Name = d.Name,
                    IsMAinSalesUnit = d.IsUnitSale,
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
                }).ToList();
            return Products.Any() ? Products : null;
        }

        public List<ProductDto> GetAll()
        {
            var Products = _context.Products.Where(d => d.IsDeleted == false)
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
                    IsMAinSalesUnit = d.IsUnitSale
                }).ToList();
            return Products.Any() ? Products : null;
        }

        public List<ProductDto> GetAllByCategory(Guid categoryId)
        {
            var Products = _context.Products
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
                    IsMAinSalesUnit = d.IsUnitSale
                }).ToList();
            return Products.Any() ? Products : null;
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
                    IsMAinSalesUnit = model.IsUnitSale
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
            if (model.Any())
            {
                return model;
            }

            return null;
        }
        public long GeneratorRandomNumber()
        {
            while (true)
            {
                var number = new Random().NextLong(0, long.MaxValue);
                if (!_context.Products.Any(d => d.ProductNumber == number))
                {
                    return number;
                }
            }
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
