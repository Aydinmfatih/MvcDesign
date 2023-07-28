using System.ComponentModel.DataAnnotations;

namespace MvcDesign.Models.ModelMetaDataTypes
{
    public class ProductMetaData
    {
        [Required(ErrorMessage = "Product name Giriniz")]
        [StringLength(100, ErrorMessage = "en fazla 100 karakter giriniz")]
        public string? ProductName { get; set; }
        [EmailAddress(ErrorMessage = "geçerli bir adres giriniz")]
        public string? Email { get; set; }
    }
}
