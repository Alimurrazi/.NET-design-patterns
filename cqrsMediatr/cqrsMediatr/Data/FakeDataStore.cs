using cqrsMediatr.Models;

namespace cqrsMediatr.Data
{
    public class FakeDataStore
    {
        private static List<Product> products;
        public FakeDataStore()
        {
            products = new List<Product>
            {
                new Product { Id = 1, Name = "Test Product1" },
                new Product { Id = 2, Name = "Test Product1" },
                new Product { Id = 3, Name = "Test Product1" }
            };
        }

        public async Task AddProduct(Product product)
        {
            products.Add(product);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await Task.FromResult(products);
        }

        public async Task<Product> GetProductById(int id)
        {
            return await Task.FromResult(products.Single(p => p.Id == id));
        }
    }
}
