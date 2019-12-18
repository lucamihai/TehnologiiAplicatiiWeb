using System.Linq;

namespace AspNetCoreMvc.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}