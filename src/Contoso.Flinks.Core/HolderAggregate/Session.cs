using Microsoft.EntityFrameworkCore;

namespace Contoso.Flinks.Core
{
    [Owned]
    public class Session
    {
        public Guid RequestId { get; set; }
    }
}
