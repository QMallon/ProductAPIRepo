using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        
        Product[] products = new Product[]
            {
            new Product { Id = 1, Name = "Potatoe Soup", Category = "Schmoceries", Price = 1 },
            new Product { Id = 2, Name = "Basketball", Category = "Sports", Price = 10.00M },
            new Product { Id = 3, Name = "Saw", Category = "Tools", Price = 19.99M }
        };
        public ProductsController()
        {

        }
        public ProductsController(Product[] products)
        {
            this.products = products;
        }
        

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

       
    }
}
