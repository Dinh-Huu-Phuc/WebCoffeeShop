
using CoffeeShop.Models.Interface;
using CoffeeShop.Models;
using CoffeeShop.Data;

namespace coffeeshop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private CoffeeShopContext dbContext;
        public ProductRepository(CoffeeShopContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return dbContext.Products;
        }

        public Product? GetProductDetail(int id) 
        { 
            return dbContext .Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return dbContext.Products.Where(p => p.IsTrendingProduct);
        }

    }

}