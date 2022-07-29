using Contoso.Flinks.Core.Dtos;

namespace Contoso.Flinks.Core.Interfaces
{
    public interface IFlinksService
    {
        Task<AuthorizeResponseDto> Authorize(AuthorizeRequestDto request);
    }
}
