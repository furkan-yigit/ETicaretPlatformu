using ETicaretPlatformu.Application.Models.DTOs.CatagoryDto;
using ETicaretPlatformu.Application.Models.VMs.CatagoryVM;
using ETicaretPlatformu.Application.Services.CategoryService;
using ETicaretPlatformu.Domain.Repositories;
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
                TempData["Error"] = "An error occurred while creating the category.";
                return View(model);               
            }
            TempData["Success"] = "Category created successfully.";
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
                TempData["Error"] = "An error occurred while updating the category.";
                return View(model);
            }

            await _categoryService.Update(model);

            
            TempData["Success"] = "Category updated successfully.";

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _categoryService.Delete(id);
                TempData["Success"] = "Category deleted successfully.";
            }
            catch (Exception ex)
            {
                TempData["Error"] = "An error occurred while deleting the category.";
                
            }

            return RedirectToAction(nameof(Index));
        }
       public async Task<IActionResult> Details(CatagoryVM  model)
        {
            
            return View(await _categoryService.GetById(model.Id));
        }
        
       
        

        
        

        
    }
}
