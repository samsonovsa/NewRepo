using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Avito.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [ForeignKey("User")]
        public int SellerId { get; set; }
        public User Seller { get; set; }

        public ICollection<Sale> Sales { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
