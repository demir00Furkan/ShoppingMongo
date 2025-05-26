using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.ViewComponents
{
    public class _DefaultHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
