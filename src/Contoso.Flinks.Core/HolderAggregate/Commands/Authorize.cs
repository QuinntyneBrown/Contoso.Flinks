using Contoso.Flinks.Core.Interfaces;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Contoso.Flinks.Core
{

    public class AuthorizeValidator: AbstractValidator<AuthorizeRequest> {
        public AuthorizeValidator()
        {
            RuleFor(x => x.LoginId)
                .NotNull()
                .NotEmpty();
        }
    }
    public class AuthorizeRequest: IRequest<AuthorizeResponse> {
        public string LoginId { get; set; } = string.Empty;
    }
    public class AuthorizeResponse: ResponseBase {
        public Guid RequestId { get; set; }
    }

    public class AuthorizeHandler: IRequestHandler<AuthorizeRequest, AuthorizeResponse>
    {
        private readonly IFlinksDb _context;
        private readonly ILogger<AuthorizeHandler> _logger;
        private readonly IFlinksClient _client;
    
        public AuthorizeHandler(IFlinksDb context, IFlinksClient client, ILogger<AuthorizeHandler> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }
    
        public async Task<AuthorizeResponse> Handle(AuthorizeRequest request, CancellationToken cancellationToken)
        {
            return new ()
            {
            };
        }
    }

}
