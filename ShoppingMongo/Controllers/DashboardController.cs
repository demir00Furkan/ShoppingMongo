using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.Serivces.CategoryServices;
using ShoppingMongo.Serivces.ProductServices;

namespace ShoppingMongo.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public DashboardController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> DashboardList()
        {
            var products = await _productService.GetAllProductAsync();
            var categories = await _categoryService.GetAllCategoriesAsync();
            ViewBag.ProductsCount = products.Count();
            var last3products= products.OrderByDescending(x=> x.ProductCreateDate).Take(3).ToList();
            ViewBag.ProductsLast3 = last3products;
            var lowStockCount = products.Count(x => x.StockCount < 10);
            ViewBag.LowStockCount = lowStockCount;
            var HighTalep = products.Count(x=>x.StockCount <3);
            ViewBag.Talep = HighTalep;
            var SumCategory = categories.Count();
            ViewBag.TotalCategories = SumCategory;
            return View();
        }
    }
}
