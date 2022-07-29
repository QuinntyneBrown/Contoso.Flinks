using Microsoft.EntityFrameworkCore;

namespace Contoso.Flinks.Core.Interfaces
{
    public interface IFlinksDb
    {
        DbSet<Holder> Holders { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
    }
}
