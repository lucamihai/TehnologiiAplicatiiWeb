using System.Linq;

namespace AspNetCoreMvc.Models
{
    public interface ICatalogRepository
    {
        IQueryable<Catalog> Catalogs { get; }
    }
}