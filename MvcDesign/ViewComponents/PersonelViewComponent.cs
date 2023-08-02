using Microsoft.AspNetCore.Mvc;

namespace MvcDesign.ViewComponents
{
    public class PersonelViewComponent:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
