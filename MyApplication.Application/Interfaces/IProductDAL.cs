using MyApplication.Core.Models;

namespace MyApplication.Application.Interfaces;

public interface IProductDAL
{
    Task<IEnumerable<Product>> GetAllAsync();

    Task<Product?> GetByIdAsync(int id);

    Task<Product> CreateAsync(Product product);
}