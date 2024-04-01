using ETicaretPlatformu.Application.Models.DTOs.CatagoryDto;
using ETicaretPlatformu.Application.Services.CategoryService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretPlatformu.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _categoryService.GetCatagories());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCatogoryDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _categoryService.Create(model);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            return View(await _categoryService.GetById(id));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateCatagoryDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _categoryService.Update(model);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
