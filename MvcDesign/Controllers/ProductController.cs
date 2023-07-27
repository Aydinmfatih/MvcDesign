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
            if (!ModelState.IsValid)
            {
                ViewBag.Message = ModelState.Values.FirstOrDefault(x=>x.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).Errors[0].ErrorMessage;
                return null;
            }
            return View();
        }
      
    }

}






