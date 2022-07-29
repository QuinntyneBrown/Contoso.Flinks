namespace Contoso.Flinks.Core.Interfaces
{
    public interface IFlinksClient
    {
        Task<AuthorizeResponse> Authorize(AuthorizeRequest request);
    }
}
