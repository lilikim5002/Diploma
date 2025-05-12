using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Spesifications;
using Microsoft.AspNetCore.Mvc;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T>GetIdAsync(int Id);
        Task<IReadOnlyList<T>>ListAllAsync();
        Task<T> GetEntityWithSpec(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        Task<ActionResult<Product>> GetByIdAsync();
    }
}