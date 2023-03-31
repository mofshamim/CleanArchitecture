using CleanArchitecture.Application;
using CleanArchitecture.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService memberService)
        {
            _productService = memberService;
        }
        // GET: api/<MembersController>
        [HttpGet]
        public ActionResult<IList<Product>> Get()
        {
            return Ok(_productService.GetProducts());
        }
    }
}


//https://www.c-sharpcorner.com/article/clean-architecture-with-asp-net-core-webapi/