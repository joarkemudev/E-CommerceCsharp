using Microsoft.AspNetCore.Mvc;
using ProductService.Models;
using ProductService.Services;
using System.Collections.Generic;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService.Services.ProductService _productService;

        public ProductsController(ProductService.Services.ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            return _productService.GetProducts();
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(string id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        [HttpPost]
        public ActionResult<Product> AddProduct(Product product)
        {
            _productService.AddProduct(product);
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(string id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            var existingProduct = _productService.GetProductById(id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            _productService.UpdateProduct(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(string id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            _productService.DeleteProduct(id);
            return NoContent();
        }
    }
}