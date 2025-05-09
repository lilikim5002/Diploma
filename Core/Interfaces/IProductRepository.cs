using System.Collections.Generic;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product>GetProductByAsync(int Id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}