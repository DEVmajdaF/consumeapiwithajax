using consumeapiwithajax.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace consumeapiwithajax.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        [Route("GetALL")]

        public IEnumerable<Product> GetAllProduct()
        {

            return productList();

        }
         List<Product> prod;

        public List<Product> productList()
        {
            prod = new List<Product>();
            {
                prod.Add(new Product() { Id = 1, ProductName = "Computer", price = 4000 });
                prod.Add(new Product() { Id = 2, ProductName = "phone", price = 3000 });
                prod.Add(new Product() { Id = 3, ProductName = "cartable", price = 1000 });
                prod.Add(new Product() { Id = 4, ProductName = "pc", price = 5000 });


            };
            return prod;
        }

        [HttpGet]
        [Route("GetById/{prodId}")]


        public Product GetProductsById(int prodID)
        {
            return productList().Where(x => x.Id == prodID).SingleOrDefault();
        }

      
        //[HttpPost]
        //public Product postdata([FromBody] Product p)
        //{
           
        //    prod.Add(p);
        //    return p;
        //}





    }
}
