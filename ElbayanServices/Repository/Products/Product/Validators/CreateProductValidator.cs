using System.Globalization;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.Product.Dtos;
using FluentValidation;

namespace ElbayanServices.Repository.Products.Product.Validators
{
    public class CreateProductValidator : AbstractValidator<ProductDto>
    {
        public CreateProductValidator()
        {
            //Name
            RuleFor(d => d.Name)
                .NotEmpty().WithMessage("يجب ألا يكون الحقل فارغاً")
                .NotNull().WithMessage("يجب ألا يكون الحقل فارغاً")
                .Must(ProductResolution.IsUnique).WithMessage("الاسم موجود بالفعل");
            //PurshaceDefaultPrice
            RuleFor(d => d.PurchaseDefaultPrice)
                .NotEmpty().WithMessage("يجب ألا يكون الحقل فارغاً")
                .NotNull().WithMessage("يجب ألا يكون الحقل فارغاً");
            //BarCode
        //    RuleFor(d => d.BarCode)
        //        .Must(ProductResolution.BarCodeIsUnique).WithMessage("الرمز الشريطي  موجود بالفعل");
        }
       
    }
}
