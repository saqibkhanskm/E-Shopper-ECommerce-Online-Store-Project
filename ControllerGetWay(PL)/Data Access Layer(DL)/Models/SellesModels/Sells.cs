using Data_Access_Layer_DL_.Models.ProductModels;
using Data_Access_Layer_DL_.Models.UserModels;
using System.ComponentModel.DataAnnotations;

namespace Data_Access_Layer_DL_.Models.SellesModels
{
    public class Sells
    {
        [Key]
        public Guid SellId { get; set; }
        public Guid ProductId { get; set; }
        public Products? Product { get; set; }
        public Guid PurchaserId { get; set; }
        public User? Purchaser { get; set; }
        public int Quantity { get; set; }
        public decimal SellPrice { get; set; }
        public DateTime SellDate { get; set; }
        public string SellingArea { get; set; }=string.Empty;

    }
}
