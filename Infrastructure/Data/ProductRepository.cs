using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext _Context;
        public ProductRepository(ApplicationContext context)
        {
            
            _Context=context;
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            
            return await _Context.Products.FindAsync(id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
           return await _Context.Products.ToListAsync();
        }
    }
}