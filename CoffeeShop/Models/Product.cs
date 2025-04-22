using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên Sản Phẩm Không Được Trống ")]
        public string? Name { get; set; }
        [Range(1000,1000000, ErrorMessage = "Giá phải từ 1000 tới 1000000")]
        public decimal Price { get; set; }
        public string? Detail { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsTrendingProduct { get; set; } = false;
    }
}
