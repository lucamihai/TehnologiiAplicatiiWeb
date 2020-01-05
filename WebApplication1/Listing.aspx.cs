using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;
using WebApplication1.Models.Repository;

namespace WebApplication1
{
    public partial class Listing : System.Web.UI.Page
    {
        private readonly Repository repo = new Repository();
        private int pageSize = 4;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected IEnumerable<Product> GetProducts()
        {
            var products = repo.Products;

            return products
                .OrderBy(p => p.ProductID)
                .Skip((CurrentPage - 1) * pageSize)
                .Take(pageSize);
        }

        protected int CurrentPage
        {
            get
            {
                int page; 
                page = int.TryParse(Request.QueryString["page"], out page) ? page : 1; 

                return page > MaxPage ? MaxPage : page;
            }
        }

        protected int MaxPage => (int)Math.Ceiling((decimal)repo.Products.Count() / pageSize);
    }
}