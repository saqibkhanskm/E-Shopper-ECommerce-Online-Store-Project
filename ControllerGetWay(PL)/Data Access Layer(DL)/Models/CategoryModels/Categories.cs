using Data_Access_Layer_DL_.Models.ProductModels;
using System.ComponentModel.DataAnnotations;

namespace Data_Access_Layer_DL_.Models.CategoryModels
{
    public class Categories
    {
        [Key]
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<Products>? Products { get; set; }

    }
}
