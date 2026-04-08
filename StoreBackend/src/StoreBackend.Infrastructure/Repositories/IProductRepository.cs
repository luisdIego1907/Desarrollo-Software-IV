using System;
using StoreBackend.Domain.Entities;

namespace StoreBackend.Infrastructure.Repositories;

public interface IProductRepository
{
    Task<List<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(Guid productId);
    Task<Product> AddAsync(Product prodcut);
    Task DeleteAsync(Product product);
}
