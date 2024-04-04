using ETicaretPlatformu.Application.Models.DTOs.ProductDTOs;
using ETicaretPlatformu.Application.Models.VMs.ProductVMs;
using ETicaretPlatformu.Application.Services.CategoryService;
using ETicaretPlatformu.Application.Services.ProductService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretPlatformu.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }


        public async Task<IActionResult> Index()
        {
            var productList = await _productService.GetProducts();
                        return View(productList);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Kategoriler = await _categoryService.GetCatagories();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddProductDto model)
        {
            if (ModelState.IsValid)
            {
                await _productService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public async Task<IActionResult> Update(int id)
        {
            ViewBag.SeciliKategori = await _categoryService.GetById(id);
            ViewBag.TumKategoriler = await _categoryService.GetCatagories();            
            return View(await _productService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateProductDto model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.TumKategoriler = await _categoryService.GetCatagories();

                return View(model);
                
            }
            else
            {
                await _productService.UpdateProduct(model);
                return RedirectToAction("Index");
            }
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _productService.Delete(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail(int id)
        {
            var product = await _productService.GetProductDetails(id);
            return View(product);
        }
    }
}
