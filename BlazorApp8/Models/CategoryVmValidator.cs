using FluentValidation;

namespace BlazorApp8.ViewModels;
public class CategoryVmValidator : AbstractValidator<CategoryVm>
{
    public CategoryVmValidator()
    {

        RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(10);
        RuleFor(x => x.Name).NotEqual("Select...");
        RuleFor(x => x.Prefix).NotEmpty().MinimumLength(3).MaximumLength(8);
        RuleFor(x => x.CategoryType).NotEqual("Select...");
        ;
    }
}