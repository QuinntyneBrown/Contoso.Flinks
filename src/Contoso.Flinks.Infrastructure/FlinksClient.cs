using Contoso.Flinks.Core;
using Contoso.Flinks.Core.Interfaces;

namespace Contoso.Flinks.Infrastructure
{
    internal class FlinksClient : IFlinksService
    {
        private readonly HttpClient _client;

        public FlinksClient(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient();
        }

        public Task<AuthorizeResponse> Authorize(AuthorizeRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
