using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.SubCategory.Dtos;
using FluentValidation;

namespace ElbayanServices.Repository.Products.SubCategory.Validators
{
    public class CreateSubCategoryValidator :AbstractValidator<SubCategoryDto>
    {
        
        public CreateSubCategoryValidator()
        {
            //Name
            RuleFor(d => d.Name)
                .NotNull().WithMessage("يجب ألا يكون الحقل فارغاً")
                .NotEmpty().WithMessage("يجب ألا يكون الحقل فارغاً")
                .Must(SubCategoryResolution.IsUnique).WithMessage("الاسم موجود بالفعل");

        }
       
    }
}
