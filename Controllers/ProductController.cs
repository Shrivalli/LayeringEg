using LayeringEg.FPModels;
using LayeringEg.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LayeringEg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProdService<Product> serviceobj;
        public ProductController(IProdService<Product> sobj)
        {
            serviceobj = sobj;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
          var prods=  serviceobj.getallproducts();
            return Ok(prods);
        }
    }
}
