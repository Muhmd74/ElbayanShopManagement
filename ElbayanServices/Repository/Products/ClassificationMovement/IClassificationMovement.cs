using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Products.ClassificationMovement.Dtos;

namespace ElbayanServices.Repository.Products.ClassificationMovement
{
    public interface IClassificationMovement
    {
        List<ClassificationMovementDto> GetAllClassificationMovement();
        List<ClassificationMovementDto> FilterClassificationMoreSale();
        List<ClassificationMovementDto>FilterClassificationLessSale();
        List<ClassificationMovementDto> GetClassificationByCategoryAndSubCategory(Guid subCategoryId, Guid? categoryId);
        List<ClassificationMovementDto> GetClassificationByDateTime
        (DateTime? firstDateTime, DateTime? lastDateTime, string orderType, Guid? productId, Guid? subCategoryId, Guid? categoryId);
        List<ClassificationMovementDto> GetClassificationSearch(string productName, long? barCode);
        List<ClassificationMovementDto> GetAllProductStockDetailsByType(string orderType);


    }
}
