using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AWS.NET_MVC_Demo.Models
{
    public class Product
    {
        [Key]
        public int productID { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public string productType { get; set; }
        [Range(0, 1000)]
        [NotNull]
        public int quantity { get; set; }
        [Required]
        public int price { get; set; }
    }
}
