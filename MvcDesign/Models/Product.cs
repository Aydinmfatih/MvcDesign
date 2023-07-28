using Microsoft.AspNetCore.Mvc;
using MvcDesign.Constants;
using MvcDesign.Models.ModelMetaDataTypes;
using System.ComponentModel.DataAnnotations;

namespace MvcDesign.Models
{
    [ModelMetadataType(typeof(ProductMetaData))]
    public class Product
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Email { get; set; }
    }
}
