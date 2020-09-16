using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _Repo;

        public ProductController(IProductRepository Repo)
        {
            _Repo = Repo;


        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var Result = await _Repo.GetProductsAsync();
            return Ok(Result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Getproduct(int id)
        {
            var product = await _Repo.GetProductByIdAsync(id);
            return Ok(product);
        }
    }
}