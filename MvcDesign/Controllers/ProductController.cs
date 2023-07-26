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

         public IActionResult CreateProduct( )
        {
            return View();
        }
        public IActionResult GetData(string a, string b)
        {
            var queryString = Request.QueryString;
             Request.Query["a"].ToString();
             Request.Query["b"].ToString();
            return View();
        }


    }
}
