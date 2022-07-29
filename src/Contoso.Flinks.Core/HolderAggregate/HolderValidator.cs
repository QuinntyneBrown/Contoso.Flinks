using FluentValidation;

namespace Contoso.Flinks.Core
{
    public class HolderValidator: AbstractValidator<HolderDto> {
        public HolderValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
