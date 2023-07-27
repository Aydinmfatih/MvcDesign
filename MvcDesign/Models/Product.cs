using MvcDesign.Constants;
using System.ComponentModel.DataAnnotations;

namespace MvcDesign.Models
{
    public class Product
    {
        [Required(ErrorMessage ="Product name Giriniz")]
        [StringLength(100,ErrorMessage ="en fazla 100 karakter giriniz")]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        [EmailAddress(ErrorMessage ="geçerli bir adres giriniz")]
        public string Email { get; set; }
    }
}
