﻿using MultiTenancy.Models;

namespace MultiTenancy.Services
{
    public interface IProductService
    {

        Task<Product> CreateAsync(Product product);

        Task<Product?> GetByIdAsync(int Id);

        Task<IReadOnlyList<Product>> GetAllAsync();

    }
}
