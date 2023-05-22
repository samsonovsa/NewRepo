using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Avito.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("User")]
        public int ReviewerId { get; set; }
        public User Reviewer { get; set; }

        [Required]
        public int Rating { get; set; }

        public string Comment { get; set; }
    }
}
