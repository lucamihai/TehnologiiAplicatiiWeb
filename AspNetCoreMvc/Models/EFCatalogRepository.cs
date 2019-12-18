using System.Linq;

namespace AspNetCoreMvc.Models
{
    public class EFCatalogRepository : ICatalogRepository
    {
        private readonly ApplicationDbContext context;

        public EFCatalogRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Catalog> Catalogs => context.Catalogs;
    }
}