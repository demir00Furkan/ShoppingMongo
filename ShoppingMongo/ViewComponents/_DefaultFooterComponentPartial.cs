using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.ViewComponents
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
