using ElbayanServices.Repository.Products.Units.SmallUnit.Dtos;
using FluentValidation;

namespace ElbayanServices.Repository.Products.Units.SmallUnit.Validators
{
    public class CreateSmallUnitValidator :AbstractValidator<SmallUnitDto>
    {
        public CreateSmallUnitValidator()
        {
            //Name
            RuleFor(d => d.Name)
                .NotNull().WithMessage("يجب ألا يكون الحقل فارغاً")
                .NotEmpty().WithMessage("يجب ألا يكون الحقل فارغاً")
                .Must(SmallUnitResolution.IsUnique).WithMessage("الاسم موجود بالفعل");

        }

    }
}
