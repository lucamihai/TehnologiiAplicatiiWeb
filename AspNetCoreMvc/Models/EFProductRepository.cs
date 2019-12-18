using System.Linq;

namespace AspNetCoreMvc.Models
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext context;
        public EFProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}