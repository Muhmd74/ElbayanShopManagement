using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Clints.Poses.Dtos;
using FluentValidation;

namespace ElbayanServices.Repository.Clints.Poses.Validators
{
    public class CreatePosValidator : AbstractValidator<PosDto>
    {
        public CreatePosValidator()
        {
            RuleFor(d => d.Name)
                .NotEmpty().WithMessage("يجب ألا يكون الحقل فارغاً")
                .NotNull().WithMessage("يجب ألا يكون الحقل فارغاً");
        }
    }
}
