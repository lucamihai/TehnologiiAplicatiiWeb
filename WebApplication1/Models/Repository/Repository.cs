using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models.Repository
{
    public class Repository
    {
        private readonly EFDbContext context = new EFDbContext(); 

        public IEnumerable<Product> Products => context.Products.ToList();
        public IEnumerable<Catalog> Catalogs => context.Catalogs.ToList();

        public void UpdateCatalog(Catalog catalog)
        {
            var alreadyExistingCatalog = context.Catalogs.FirstOrDefault(x => x.Id == catalog.Id);

            if (alreadyExistingCatalog == null)
            {
                throw new InvalidOperationException($"There's no catalog with ID = {catalog.Id}");
            }

            alreadyExistingCatalog.FirstName = catalog.FirstName;
            alreadyExistingCatalog.LastName = catalog.LastName;
            alreadyExistingCatalog.Mark = catalog.Mark;
            alreadyExistingCatalog.FirstGrade = catalog.FirstGrade;
            alreadyExistingCatalog.SecondGrade = catalog.SecondGrade;

            context.SaveChanges();
        }
    }
}