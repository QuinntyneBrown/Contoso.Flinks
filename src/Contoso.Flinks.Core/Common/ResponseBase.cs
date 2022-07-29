using System.Collections.Generic;

namespace Contoso.Flinks.Core
{
    public class ResponseBase
    {
        public List<string> ValidationErrors { get; set; } = new();
    }
}
