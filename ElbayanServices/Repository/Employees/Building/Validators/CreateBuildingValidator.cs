using ElbayanServices.Repository.Employees.Building.Dtos;
using FluentValidation;

namespace ElbayanServices.Repository.Clints.Building.Validators
{
    public class CreateBuildingValidator : AbstractValidator<BuildingDto>
    {
        public CreateBuildingValidator()
        {
            RuleFor(d => d.Name)
                .NotEmpty().WithMessage("يجب ألا يكون الحقل فارغاً")
                .NotNull().WithMessage("يجب ألا يكون الحقل فارغاً");
        }
    }
}
