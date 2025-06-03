using Microsoft.EntityFrameworkCore;
using TH01.Models;

namespace TH01.Data
{
    public class CoffeeshopDbContext:DbContext
    {
        public CoffeeshopDbContext(DbContextOptions<CoffeeshopDbContext> options) :base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingcartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrdersDetail { get; set; }
        //seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "America",
                Price = 25,
                Detail = "Americano là một shot espresso pha với nước nóng. Nó thường được pha trong một cốc 6 ounce và gồm một nửa espresso và một nửa nước nóng, hoặc ⅓ espresso và ⅔ nước nóng.\n Thông thường mọi người sẽ uống nước, sau đó thêm espresso lên trên, \n vì nó giữ được lớp crema, là lớp bọt màu nâu đỏ, nhưng cũng có thể làm ngược lại.",
                ImageUrl =
            "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp"
            },
            new Product
            {
                Id = 2,
                Name = "Vietnam",
                Price = 20,
                Detail = "Trung Nguyen Legend is a Vietnamese business group engaged in coffee production, processing, and distribution. It is known as the largest domestic coffee brand in Vietnam, exporting products to over 60 countries, including major markets such as G7 countries, the United States,\n the European Union, the United Kingdom, Germany, China, Canada, Russia, Japan, Dubai, and ASEAN. When talking about quality Vietnamese coffee,\n this brand with its aromatic and robust coffee cannot be overlooked",
                ImageUrl =
            "https://bna.1cdn.vn/2025/02/02/cdnphoto.dantri.com.vn-i7ew_jatefe35zxjrpzbe0euvlk-thumb_w-1020-2022-08-06-_caphe-1659747941762.jpeg"
            },
            new Product
            {
                Id = 3,
                Name = "United Kingdom",
                Price = 15,
                Detail = "In the UK, coffee preferences are varied but a\n few stand out as particularly popular. While many enjoy flat whites\n, cappuccinos, and lattes, the most popular coffee drink in the UK is the flat white",
                ImageUrl =
            "https://images2.thanhnien.vn/528068263637045248/2023/9/8/cafefqxn-16941744457661231106144.jpg"
            },
            new Product
            {
                Id = 4,
                Name = "India",
                Price = 15,
                Detail = "Indian Mysore coffee is a market name for high-quality wet processed (washed)\n coffees from the southern region in the state of Karnataka. The coffee is known for its subtle,\n rich flavor complemented by a medium to full body and moderate though distinct acidity.",
                ImageUrl =
            "https://suckhoedoisong.qltns.mediacdn.vn/324455921873985536/2024/10/16/ca-phe-1-17290637850462076395892.jpg"
            },
            new Product
            {
                Id = 5,
                Name = "Russian",
                Price = 25,
                Detail = "Raf coffee (Russian: раф-кофе) is a popular coffee drink in some countries of the former USSR,\n which appeared in the late 1990s in Russia. Prepared by adding cream and vanilla sugar to a single shot of espresso and\n then foaming the mix with a steam heater.",
                ImageUrl =
            "https://simexcodl.com.vn/wp-content/uploads/2023/11/cac-loai-ca-phe-o-viet-nam-8.jpg"
            },
            new Product
            {
                Id = 6,
                Name = "France",
                Price = 35,
                Detail = "This refers to regular black coffee. It is usually served in small portions as an espresso or French press coffee.\n The French enjoy café noir with meals or as a pick-me-up in the afternoon.",
                ImageUrl =
            "https://file.hstatic.net/1000274203/article/ca_phe_robusta_va_arabica_loai_nao_ngon_09d00c9c4e76439786c981c7a8c43cd0.jpg"
            }
            );
        }
    }
}
