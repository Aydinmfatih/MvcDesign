using System.ComponentModel.DataAnnotations;

namespace MvcDesign.Models
{
    public class Product
    {
        [Required("")]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Email { get; set; }
    }
}
