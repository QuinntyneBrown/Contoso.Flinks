using Contoso.Flinks.Core.Interfaces;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Contoso.Flinks.Core
{

    public class AuthorizeValidator: AbstractValidator<AuthorizeRequest> { }
    public class AuthorizeRequest: IRequest<AuthorizeResponse> { }
    public class AuthorizeResponse: ResponseBase { }
    public class AuthorizeHandler: IRequestHandler<AuthorizeRequest, AuthorizeResponse>
    {
        private readonly IFlinksDb _context;
        private readonly ILogger<AuthorizeHandler> _logger;
    
        public AuthorizeHandler(IFlinksDb context, ILogger<AuthorizeHandler> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    
        public async Task<AuthorizeResponse> Handle(AuthorizeRequest request, CancellationToken cancellationToken)
        {
            return new ()
            {
            };
        }
        
    }

}
