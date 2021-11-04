using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(product => product.ProductName).NotEmpty();
            RuleFor(product => product.ProductName).MinimumLength(8);
            RuleFor(product => product.UnitPrice).NotEmpty();
            RuleFor(product => product.UnitPrice).GreaterThanOrEqualTo(0);
            RuleFor(product => product.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            RuleFor(product => product.ProductName).Must(StartWithA).WithMessage("A harfi ile başlamalıdır.");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}