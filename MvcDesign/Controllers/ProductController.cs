using Microsoft.AspNetCore.Mvc;
using MvcDesign.Models;

namespace MvcDesign.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProduct()
        {
            return View();
        }

        public IActionResult CreateProduct()
        {
            var tuple = (new Product(), new User());
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct((Product product, User user) model)
        {


            return View();
        }
      

    }

}






