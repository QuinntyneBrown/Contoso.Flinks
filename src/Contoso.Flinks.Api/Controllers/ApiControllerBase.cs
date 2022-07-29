using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace Contoso.Flinks.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class ApiControllerBase: ControllerBase
    {
    }
}
