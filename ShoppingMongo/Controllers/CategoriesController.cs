using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.Dtos.CategoryDto;
using ShoppingMongo.Serivces.CategoryServices;

namespace ShoppingMongo.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> CategoryList(string search)
        {
            var values = await _categoryService.GetAllCategoriesAsync();

            if (!string.IsNullOrEmpty(search))
            {
                
                values = values
                    .Where(x => x.CategoryName != null && x.CategoryName.ToLower().Contains(search.ToLower()))
                    .ToList();
            }

            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            await _categoryService.CreateCategoryAsync(createCategoryDto);  
            return RedirectToAction("CategoryList");
        }
        public async Task<IActionResult> DeleteCategory(string id)
        {
            await _categoryService.DeleteCategoryAsync(id);
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCategory(string id)
        {
            var values = await _categoryService.GetCategoryByIdDtoAsync(id);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            await _categoryService.UpdateCategoryAsync(updateCategoryDto);
            return RedirectToAction("CategoryList");
        }
    }
}
