using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.Models;
using ShoppingMongo.Serivces.ProductServices;

namespace ShoppingMongo.ViewComponents
{
    public class _DefaultPreviewProductComponentPartial:ViewComponent
    {
        private readonly IProductService _productService;

        public _DefaultPreviewProductComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public async Task< IViewComponentResult> InvokeAsync()
        {
            var products = await _productService.GetAllProductAsync(); 
            var model = new PreviewProductViewModel
            {
                Products = products
            };
            return View(model); 
        }
    }
}
