namespace Avito.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SellerId { get; set; }
        public int BuyerId { get; set; }
        public decimal Price { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
