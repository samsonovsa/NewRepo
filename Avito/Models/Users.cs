﻿using System.ComponentModel.DataAnnotations;

namespace Avito.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Sale> Sales { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Sale> BuyerSales { get; set; }
        public ICollection<Sale> SellerSales { get; set; }
    }
}
