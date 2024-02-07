using FluentValidation;

namespace BlazorApp8.ViewModels;
public class VendorVmValidator : AbstractValidator<VendorVm>
{
    public VendorVmValidator()
    {
        RuleFor(x => x.Name).MinimumLength(3).MaximumLength(25);
        RuleFor(x => x.Name).NotEqual("Select...");
    }
}
