using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Products.Product.Dtos;
using ElbayanServices.Repository.Products.SubCategory.Dtos;
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
        List<ProductDto> GetAllEqualZero();
        List<ProductDto> GetProductsLimitedDemand();
        List<ProductDto> GetAllByCategory(Guid categoryId);
        List<SmallUnitNameDto> GetAllSmallUnitByLargeUnit(Guid largeUnitId);
        List<SmallUnitNameDto> GetAllSmallUnit();
        List<SubCategoryNameDto> GetAllSubCategory();
        List<LargeUnitNameDto> GetAllLargeUnit();
        ProductDto GetById(Guid id);
        List<ProductDto> GetByName(string productName,long? barcode,int? productNumber);
        List<ProductNameDto> GetAllProductName();
        long GetBarcodeByProductName(string productName);
        long GetBarcodeByProductNumber(int productNumber);
    }
}
