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
            new Product();
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product model)
        {
            
            return View();
        }
      
    }

}






