using System.ComponentModel.DataAnnotations;
using IWantToBuy.Models.Enum;

namespace IWantToBuy.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(120, ErrorMessage = "Product name must be a maximum of 120 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You need to put the url of the product")]
        public string ProductUrl { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public double Price { get; set; }
        [Required(ErrorMessage = "You need to select a category")]
        public Category Category { get; set; }
    }
}