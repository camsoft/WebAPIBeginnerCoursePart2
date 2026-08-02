using WebAPICourse.Models;
using WebAPICourse.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace WebAPICourse.Repositories
{
    // Repositories/ProductRepository.cs
    public class ProductRepository : IProductRepository
    {
        // A simple mock database for beginner demonstration
        private readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Wireless Mouse", Description = "Ergonomic wireless mouse", Price = 24.99m, StockQuantity = 150 },
            new Product { Id = 2, Name = "Mechanical Keyboard", Description = "RGB backlit mechanical keyboard", Price = 89.99m, StockQuantity = 75 },
            new Product { Id = 3, Name = "USB-C Hub", Description = "7-in-1 USB-C hub", Price = 39.99m, StockQuantity = 200 }
        };

        private int _nextId = 4;

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            return Task.FromResult(_products.AsEnumerable());
        }

        public Task<Product?> GetByIdAsync(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            return Task.FromResult(product);
        }

        public Task<Product> CreateAsync(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
            return Task.FromResult(product);
        }

        public Task<bool> UpdateAsync(Product product)
        {
            var existing = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existing is null)
            {
                return Task.FromResult(false);
            }

            existing.Name = product.Name;
            existing.Description = product.Description;
            existing.Price = product.Price;
            existing.StockQuantity = product.StockQuantity;

            return Task.FromResult(true);
        }

        public Task<bool> DeleteAsync(int id)
        {
            var existing = _products.FirstOrDefault(p => p.Id == id);
            if (existing is null)
            {
                return Task.FromResult(false);
            }

            _products.Remove(existing);
            return Task.FromResult(true);
        }


    }
}
