using ApiFirst_Codes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ApiFirst_Codes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private List<Product> _products = new List<Product>()
        {
            new Product
            {
                Id=1,
                Name="Cup",
                Price = 1.5m
            },

            new Product
            {
                Id=2,
                Name="Monitor",
                Price = 400.55m
            },

            new Product
            {
                Id=3,
                Name="TV",
                Price = 500.99m
            },

            new Product
            {
                Id=4,
                Name="Carpet",
                Price = 234.5m
            }
        };
        [HttpGet("get/{id?}")]
       
        public IActionResult Get(int id)
        {
            Product product = _products.FirstOrDefault(p=>p.Id==id);
            if( product==null) return NotFound();
            return Ok(product);
        }
        [HttpGet("all")]

        public IActionResult GetAll()
        {
            return Ok(_products);
        }
 
    }
}
