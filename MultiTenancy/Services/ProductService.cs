using Microsoft.EntityFrameworkCore;
using MultiTenancy.Data;
using MultiTenancy.Models;

namespace MultiTenancy.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Product> CreateAsync(Product product)
        {

            _dbContext.Products.Add(product);

            await _dbContext.SaveChangesAsync();    

            return product;
        }

        public async Task<IReadOnlyList<Product>> GetAllAsync()
        {

            return await _dbContext.Set<Product>().ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int Id)
        {
            return await _dbContext.Products.FindAsync(Id);        }
    }
}
