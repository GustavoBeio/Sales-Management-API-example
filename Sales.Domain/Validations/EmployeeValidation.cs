using FluentValidation;
using Sales.Domain.Models;

namespace Sales.Domain.Validations
{
    public class EmployeeValidation : AbstractValidator<EmployeeModel>
    {
        public EmployeeValidation() 
        {
            ValidatorOptions.Global.DefaultClassLevelCascadeMode = CascadeMode.Stop;

            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .Length(3, 30);

            RuleFor(x => x.Login)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Passwordhash)
                .NotNull()
                .NotEmpty()
                .MinimumLength(6);
        }
    }
}
