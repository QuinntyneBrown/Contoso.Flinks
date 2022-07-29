using Contoso.Flinks.Core.Dtos;
using Contoso.Flinks.Core.Interfaces;
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
        private readonly IFlinksService _flinksService;

        public HolderController(IMediator mediator, IFlinksService flinksService, ILogger<HolderController> logger)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _flinksService = flinksService ?? throw new ArgumentNullException(nameof(flinksService));
        }


        [SwaggerOperation(
            Summary = "Authorize",
            Description = @"Authorize"
        )]
        [HttpPost(Name = "authorize")]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ProblemDetails), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(AuthorizeResponseDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<AuthorizeResponseDto>> Create([FromBody]AuthorizeRequestDto request, CancellationToken cancellationToken)
        {
            _logger.LogInformation(
                "----- Handled: {CommandName}: ({@Command})",
                nameof(AuthorizeRequestDto),
                request);
        
            return await _flinksService.Authorize(request);
        }        
    }
}
