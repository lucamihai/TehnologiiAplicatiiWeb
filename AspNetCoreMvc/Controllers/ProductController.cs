using AspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }


        public ViewResult List() => View(repository.Products);
    }
}