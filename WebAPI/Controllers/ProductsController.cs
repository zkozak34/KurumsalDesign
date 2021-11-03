using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var p = _productService.GetAll();
            if (p.IsSucceed)
            {
                return Ok(p.Data);
            }
            return BadRequest(p.Message);
        }

        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            var p = _productService.Get(p => p.ProductId == id);
            if (p.IsSucceed)
            {
                return Ok(p.Data);
            }

            return BadRequest("Bir hata meydana geldi.");
        }

        [HttpPost("Add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.IsSucceed)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        
    }
}