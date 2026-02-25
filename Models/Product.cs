using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AWS.NET_MVC_Demo.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "Product ID")]
        public int productID { get; set; }
        [Display(Name = "Product Name")]
        public string productName { get; set; }
        [Display(Name = "Description")]
        public string productDescription { get; set; }
        [Display(Name = "Product Type")]
        public string productType { get; set; }
        [Range(0, 1000)]
        [NotNull]
        [Display(Name = "Product Quantity")]
        public int quantity { get; set; }
        [Required]
        [Display(Name = "Product Price")]
        public int price { get; set; }
    }
}
