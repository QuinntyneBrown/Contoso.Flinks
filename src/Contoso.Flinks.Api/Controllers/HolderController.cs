using Contoso.Flinks.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Contoso.Flinks.Api.Controllers
{

    public class HolderController: ApiControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<HolderController> _logger;

        public HolderController(IMediator mediator, ILogger<HolderController> logger)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        
        [SwaggerOperation(
            Summary = "Create Holder.",
            Description = @"Create Holder."
        )]
        [HttpPost(Name = "createHolder")]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ProblemDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(AuthorizeResponse), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<AuthorizeResponse>> Create([FromBody]AuthorizeRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation(
                "----- Sending command: {CommandName}: ({@Command})",
                nameof(AuthorizeRequest),
                request);
        
            return await _mediator.Send(request, cancellationToken);
        }        
    }
}
