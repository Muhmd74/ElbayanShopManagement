using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Clints.Customer.Dtos;
using FluentValidation;

namespace ElbayanServices.Repository.Clints.Supplier.Validators
{
   public class CreateSupplierValidators : AbstractValidator<ClintDto>
    {
        public CreateSupplierValidators()
        {
            RuleFor(d=>d.Name)
                .NotEmpty().WithMessage("يجب ألا يكون الحقل فارغاً")
                .NotNull().WithMessage("يجب ألا يكون الحقل فارغاً");

            RuleFor(d => d.Mobile)
                .NotEmpty().WithMessage("يجب ألا يكون الحقل فارغاً")
                .NotNull().WithMessage("يجب ألا يكون الحقل فارغاً");
        }

    }
}
