using WebAPICourse.Models;

namespace WebAPICourse.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);
        Task<ServiceResult<Product>> CreateProductAsync(Product product);
        Task<ServiceResult<bool>> UpdateProductAsync(int id, Product product);
        Task<bool> DeleteProductAsync(int id);
    }
}
