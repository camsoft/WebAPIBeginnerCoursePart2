using WebAPICourse.Models;
using WebAPICourse.Repositories;
using System.Collections.Generic;

namespace WebAPICourse.Services
{
    // Services/IProductService.cs
    public interface IProductService
    {
        IEnumerable<Product> GetAvailableProducts();
        bool CreateProduct(Product product);
    }

    // Services/ProductService.cs
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        // The Service layer asks the Repository layer for data
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetAvailableProducts()
        {
            return _repository.GetAll();
        }

        public bool CreateProduct(Product product)
        {
            // Business Rule Example: Beginners love seeing real validation logic
            if (product.Price <= 0)
            {
                return false; // Reject products with invalid prices
            }

            _repository.Add(product);
            return true;
        }
    }

}
