using System.ComponentModel.DataAnnotations;

namespace eCommerce.Model
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Description { get; set; }
        [MaxLength(255)]
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
