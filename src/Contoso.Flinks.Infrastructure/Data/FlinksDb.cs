using Contoso.Flinks.Core;
using Contoso.Flinks.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace Contoso.Flinks.Infrastructure.Data
{
    public class FlinksDb: DbContext, IFlinksDb
    {
        public DbSet<Holder> Holders { get; private set; }
        public FlinksDb(DbContextOptions options)
            :base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FlinksDb).Assembly);
        }
        
    }
}
