using FluentValidation;
using Sales.Domain.Models;

namespace Sales.Domain.Validations
{
    public class ProductOrderValidation : AbstractValidator<ProductOrderModel>
    {
        public ProductOrderValidation()
        {
            ValidatorOptions.Global.DefaultClassLevelCascadeMode = CascadeMode.Stop;

            RuleFor(x => x.Client)
                .NotNull();

            RuleFor(x => x.ProductOrderItems)
                .NotNull();

            RuleFor(x => x.ProductOrderItems.Count)
                .NotEqual(0);
        }
    }
}
