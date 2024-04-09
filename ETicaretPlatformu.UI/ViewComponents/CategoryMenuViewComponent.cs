using ETicaretPlatformu.Application.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretPlatformu.UI.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryMenuViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _categoryService.GetCatagories();
            return View(categories);
        }
    }
}
