using Data_Access_Layer_DL_.Models.CategoryModels;
using Data_Access_Layer_DL_.Models.SellesModels;

namespace Data_Access_Layer_DL_.Models.ProductModels
{
    public class Products
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public DateTime ListedDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public decimal ProductPrice { get; set; }
        public int StockQuantity { get; set; }
        public Guid CategoryId { get; set; }
        public Categories? Category { get; set; }
        public ICollection<Sells>? Sells { get; set; }

    }
}
