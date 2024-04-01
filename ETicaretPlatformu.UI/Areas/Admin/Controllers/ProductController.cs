using ETicaretPlatformu.Application.Models.DTOs.ProductDTOs;
using ETicaretPlatformu.Application.Models.VMs.ProductVMs;
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
       
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

     
        public async Task<IActionResult> Index()
        {
            var productList = await _productService.GetProducts();
                        return View(productList);
        }

        public IActionResult Create()
        {
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
            var product = await _productService.GetById(id);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateProductDto model)
        {
            if (ModelState.IsValid)
            {
                await _productService.UpdateProduct(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
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
