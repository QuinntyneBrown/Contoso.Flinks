using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Contoso.Flinks.Core
{
    public static class HolderExtensions
    {
        public static HolderDto ToDto(this Holder holder)
        {
            return new ()
            {
                HolderId = holder.HolderId,
                Name = holder.Name,
            };
        }
        
        public static async Task<List<HolderDto>> ToDtosAsync(this IQueryable<Holder> holders, CancellationToken cancellationToken)
        {
            return await holders.Select(x => x.ToDto()).ToListAsync(cancellationToken);
        }
        
        public static List<HolderDto> ToDtos(this IEnumerable<Holder> holders)
        {
            return holders.Select(x => x.ToDto()).ToList();
        }
        
    }
}
