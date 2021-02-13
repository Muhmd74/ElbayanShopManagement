using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.Product.Dtos;

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
            Random randomNumber = new Random();
            var result = _context.Products.Add(new ElbayanDatabase.DataClasses.Product.Product()
            {
                Description = model.Description,
                Name = model.Name,
                BarCode = model.BarCode,
                DefaultPrice = model.DefaultPrice,
                IsExpired = model.IsExpired,
                LargeUnitId = model.LargeUnitId,
                LimitedDemand = model.LimitedDemand,
                ProductNumber = randomNumber.Next(0, Int32.MaxValue),
                SmallUnitId = model.SmallUnitId,
                SubCategoryId = model.SubCategoryId,
                UCP = model.UCP,
                IsDeleted = false,
                DateTime = DateTime.UtcNow
            });
            _context.SaveChanges();
            return true;

        }

        public bool Update(ProductDto model)
        {
            var result = _context.Products.FirstOrDefault(d => d.Id == model.Id);
            if (result != null)
            {
                result.Description = model.Description;
                result.Name = model.Name;
                result.BarCode = model.BarCode;
                result.DefaultPrice = model.DefaultPrice;
                result.LargeUnitId = model.LargeUnitId;
                result.SmallUnitId = model.SmallUnitId;
                result.LimitedDemand = model.LimitedDemand;
                result.SubCategoryId = model.SubCategoryId;
                result.UCP = model.UCP;
                _context.SaveChanges();
                return true;

            }

            return false;
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
                    BarCode = d.BarCode,
                    DefaultPrice = d.DefaultPrice,
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
                    SubCategoryName = d.SubCategory.Name
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
                    DefaultPrice = d.DefaultPrice,
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
                    SubCategoryName = d.SubCategory.Name
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
                    DefaultPrice = model.DefaultPrice,
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

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
