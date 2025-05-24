using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.Serivces.ProductServices;

namespace ShoppingMongo.ViewComponents
{
    public class _DefaultProductComponentPartial:ViewComponent
    {
        private readonly IProductService _productService;

        public _DefaultProductComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> Invoke()
        {
            var values = await _productService.GetAllProductAsync();
            return View(values);
        }
    }
}