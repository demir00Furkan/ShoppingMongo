using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.ViewComponents
{
    public class _DefaultScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
