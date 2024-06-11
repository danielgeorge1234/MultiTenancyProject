using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiTenancy.Models;
using MultiTenancy.Services;

namespace MultiTenancy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }



        [HttpGet]

        public async Task <IActionResult> GetAllAsync()
        {
            var products = await _productService.GetAllAsync();
            return Ok(products);

        }


        [HttpGet(template:"{id:int}")]

        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var proudcts =_productService.GetByIdAsync(id);
            if (proudcts is null)
            {
                return NotFound();
            }
            return Ok(proudcts);    
        }


        [HttpPost]

        public async Task<IActionResult> CreateProduct(Product product)
        {
            var Product = await _productService.CreateAsync(product);
            return Ok(Product);
        }

    }
}
