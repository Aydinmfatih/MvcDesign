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
           var product = new Product();
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product model)
        {
            if (!ModelState.IsValid)
            {
                var messages = ModelState.ToList();
                return View(model);
            }
            return View();
        }
      
    }

}






