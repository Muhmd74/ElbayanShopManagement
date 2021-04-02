using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Employees.Employees.Dtos;
using ElbayanServices.Repository.Products.Product.Validators;
using FluentValidation;

namespace ElbayanServices.Repository.Employees.Employees.Validators
{
   public class CreateEmployeeValidator : AbstractValidator<EmployeeDto>
    {
        public CreateEmployeeValidator()
        {
            //Name
            RuleFor(d => d.Name)
                .NotEmpty().WithMessage("يجب ألا يكون حقل الاسم فارغا")
                .NotNull().WithMessage("يجب ألا يكون الحقل فارغاً"); 
            //Email
            RuleFor(d => d.Email)
                .NotEmpty().WithMessage("يجب ألا يكون الحقل فارغاً")
                .NotNull().WithMessage("يجب ألا يكون الحقل فارغاً")
                .Must(EmployeeResolution.EmailIsUnique).WithMessage("الاسم موجود بالفعل");
            //Mobile
            RuleFor(d => d.Mobile)
                .NotEmpty().WithMessage("يجب ألا يكون الحقل فارغاً")
                .NotNull().WithMessage("يجب ألا يكون الحقل فارغاً")
                .Must(EmployeeResolution.MobileIsUnique).WithMessage("رقم الهاتف موجود بالفعل"); ;
            //Password
            RuleFor(d => d.Password)
                .NotEmpty().WithMessage("يجب ألا يكون الحقل فارغاً")
                .NotNull().WithMessage("يجب ألا يكون الحقل فارغاً");

        }
    }
}
