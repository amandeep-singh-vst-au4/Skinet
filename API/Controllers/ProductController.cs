using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController:ControllerBase
    {
       private readonly StoreContext _context;
        public ProductController(StoreContext context)
        {
           _context=context;
            
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var product=await _context.Products.ToListAsync();
            return product;
        }

         [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "this will be a  product";
        }
        
    }
}