using ETicaretPlatformu.Application.Services.CategoryService;
using ETicaretPlatformu.Application.Services.ProductService;
using ETicaretPlatformu.InfraStructure.Repositories;
using ETicaretPlatformu.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ETicaretPlatformu.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public HomeController(ILogger<HomeController> logger, IProductService productService, ICategoryService categoryService)
        {
            _logger = logger;
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index(string term="", decimal minPrice = 0, decimal maxPrice = 0)
        {         

            ViewBag.TumKategoriler = await _categoryService.GetCatagories();
            var productList = await _productService.SearchByName(term);

            if (minPrice > 0 || maxPrice > 0)
            {
                productList = await _productService.FilterByPrice(maxPrice, minPrice);
            }

            return View(productList);
        }

        public async Task<IActionResult> FilterByCategory(int categoryId)
        {
            ViewBag.TumKategoriler = await _categoryService.GetCatagories();

            if (categoryId == 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                var productList = await _productService.GetByCategory(categoryId);
                return View("Index", productList);
            }                        
        }       

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
