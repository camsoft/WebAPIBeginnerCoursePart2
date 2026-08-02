using WebAPICourse.Models;
using WebAPICourse.Repositories;
using WebAPICourse.Services;
using System.Collections.Generic;

namespace WebAPICourse.Services
{
    // Services/ProductService.cs
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<ServiceResult<Product>> CreateProductAsync(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
            {
                return ServiceResult<Product>.Fail("Product name is required.");
            }

            if (product.Price <= 0)
            {
                return ServiceResult<Product>.Fail("Product price must be greater than zero.");
            }

            if (product.StockQuantity < 0)
            {
                return ServiceResult<Product>.Fail("Stock quantity cannot be negative.");
            }

            var created = await _repository.CreateAsync(product);
            return ServiceResult<Product>.Ok(created);
        }

        public async Task<ServiceResult<bool>> UpdateProductAsync(int id, Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
            {
                return ServiceResult<bool>.Fail("Product name is required.");
            }

            if (product.Price <= 0)
            {
                return ServiceResult<bool>.Fail("Product price must be greater than zero.");
            }

            product.Id = id;
            var updated = await _repository.UpdateAsync(product);

            return updated
                ? ServiceResult<bool>.Ok(true)
                : ServiceResult<bool>.Fail($"Product with ID {id} was not found.");
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

    }

}
