﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Products.Product.Dtos;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;

namespace ElbayanServices.Repository.Products.Product
{
    public interface IProduct
    {
        bool Add(ProductDto model);
        bool Update(ProductDto model);
        bool IsDeleted(Guid id);
        bool MainSalesUnit(Guid id);
        List<ProductDto> GetAllProductDeleted();
        List<ProductDto> GetAll();
        List<ProductDto> GetAllByCategory(Guid categoryId);
        List<SmallUnitNameDto> GetAllSmallUnitByLargeUnit(Guid largeUnitId);
        ProductDto GetById(Guid id);
        ProductDto GetByName(string productName);
        List<ProductNameDto> GetAllProductName();
    }
}
