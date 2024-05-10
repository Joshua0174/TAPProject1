using BusinessLayer.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{       
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
                _productService = productService;
        }
        
        [HttpGet("GetAllProducts")]
        public IActionResult Get()
        {
            var products=_productService.GetAll();
            return Ok(products);
        }
    }
}
