using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.Serivces.CategoryServices;

namespace ShoppingMongo.ViewComponents
{
    public class _DefaultCategoryComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _DefaultCategoryComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetAllCategoriesAsync();
            return View(values);
        }
    }
}
