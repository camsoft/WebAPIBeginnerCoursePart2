using WebAPICourse.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebAPICourse.Repositories
{
    // Repositories/IProductRepository.cs
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        void Add(Product product);
    }

    // Repositories/ProductRepository.cs
    public class ProductRepository : IProductRepository
    {
        // A simple mock database for beginner demonstration
        private static readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 999.99m },
            new Product { Id = 2, Name = "Mouse", Price = 49.99m }
        };

        public IEnumerable<Product> GetAll() => _products;

        public void Add(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }
    }
}
