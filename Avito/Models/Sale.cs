using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Avito.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("User")]
        [Column("seller_id")]
        public int SellerId { get; set; }
        public User Seller { get; set; }

        [ForeignKey("User")]
        [Column("buyer_id")]
        public int BuyerId { get; set; }
        public User Buyer { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime SaleDate { get; set; }
    }
}
