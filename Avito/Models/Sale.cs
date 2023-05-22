using System.ComponentModel.DataAnnotations;

namespace Avito.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        public Product Product { get; set; }

        public User Seller { get; set; }

        public User Buyer { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime SaleDate { get; set; }
    }
}
