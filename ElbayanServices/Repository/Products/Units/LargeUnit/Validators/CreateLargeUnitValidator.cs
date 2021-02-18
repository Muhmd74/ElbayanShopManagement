using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using FluentValidation;

namespace ElbayanServices.Repository.Products.Units.LargeUnit.Validators
{
    public class CreateLargeUnitValidator : AbstractValidator<LargeUnitDto>
    {
        public CreateLargeUnitValidator()
        {
            //Name
            RuleFor(d => d.Name)
                .NotNull().WithMessage("يجب ألا يكون الحقل فارغاً")
                .NotEmpty().WithMessage("يجب ألا يكون الحقل فارغاً")
                .Must(LargeUnitResolution.IsUnique).WithMessage("الاسم موجود بالفعل");
        }

    }
}
