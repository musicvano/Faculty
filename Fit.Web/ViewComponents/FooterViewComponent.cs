using Microsoft.AspNetCore.Mvc;

namespace Fit.Web.ViewComponents
{
    public class FooterViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}