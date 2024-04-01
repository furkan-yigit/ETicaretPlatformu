using ETicaretPlatformu.Application.Services.ProductService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretPlatformu.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public Task<IActionResult> Create() 
        //{
            
        //}
    }
}
