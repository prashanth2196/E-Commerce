using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public ProductController(ApplicationContext context)
        {
            _context = context;

        }
        [HttpGet]
        public  async Task<ActionResult<List<Product>>> GetProducts()
        {
            var reslut =await _context.Products.ToListAsync();
            return Ok(reslut);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Getproduct(int id)
        {
           var product= await _context.Products.FindAsync(id);
           return Ok(product);
        }
    }
}