using FluentValidation;
using Sales.Domain.Models;

namespace Sales.Domain.Validations
{
    public class ProductValidation :AbstractValidator<ProductModel>
    {
        public ProductValidation()
        {
            ValidatorOptions.Global.DefaultClassLevelCascadeMode = CascadeMode.Stop;

            RuleFor(x => x.Description)
               .NotNull()
               .NotEmpty()
               .Length(3, 30);

            RuleFor(x => x.Sellvalue)
                .NotEqual(0)
                .NotEmpty();
        }
    }
}
