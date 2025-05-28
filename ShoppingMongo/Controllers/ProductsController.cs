using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingMongo.Dtos.ProductDto;
using ShoppingMongo.Serivces.CategoryServices;
using ShoppingMongo.Serivces.ProductServices;

namespace ShoppingMongo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> ProductList(string search)
        {

            var values = await _productService.GetAllProductAsync();

            if (!string.IsNullOrEmpty(search))
            {
                values = values
                    .Where(x => x.ProductName != null && x.ProductName.ToLower().Contains(search.ToLower()))
                    .ToList();
            }

            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();
            ViewBag.Categories = categories.Select(x=> new SelectListItem
            {
                Text=x.CategoryName,
                Value=x.CategoryId,
            }).ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productService.CreateProductAsync(createProductDto);
            return RedirectToAction("ProductList");
        }
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return RedirectToAction("ProductList");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProduct(string id)
        {
            var values = await _productService.GetProductByIdDtoAsync(id);
            var categories = await _categoryService.GetAllCategoriesAsync();
            ViewBag.Categories = categories.Select(x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.CategoryId,
            }).ToList();
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _productService.UpdateProductAsync(updateProductDto);
            return RedirectToAction("ProductList");
        }
        
    }
}
