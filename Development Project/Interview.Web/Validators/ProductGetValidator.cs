using FluentValidation;
using Interview.Models.App_Layer.Requests;

namespace Interview.Web.Validators
{
    public class ProductGetValidator : AbstractValidator<ProductGetRequest>
    {
        public ProductGetValidator()
        {
            RuleFor(x => x.Product).NotNull().WithMessage("Please supply a Product object.");
            RuleFor(x => x.Product.RecordGuid).NotEmpty().WithMessage("Please supply a valid Product GUID.");
        }
    }
}
