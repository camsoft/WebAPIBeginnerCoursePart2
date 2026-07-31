using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPICourse.Services;
using WebAPICourse.Models;
using System.Collections.Generic;

namespace WebAPICourse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        // The Controller layer asks the Service layer to process requests
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            var products = _productService.GetAvailableProducts();
            return Ok(products); // Returns HTTP 200 OK
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            var isCreated = _productService.CreateProduct(product);

            if (!isCreated)
            {
                return BadRequest("Invalid product data. Price must be greater than zero."); // Returns HTTP 400
            }

            return StatusCode(201, product); // Returns HTTP 201 Created
        }
    }
}
