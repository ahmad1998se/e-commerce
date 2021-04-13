using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repo;
        public ProductsController(IProductRepository repo)
        {
            _repo = repo;

        }
        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            var products = _repo.GetProductsAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _repo.GetProductByIdAsync(id);
        }
        [HttpGet("brands")]
        public async Task<ActionResult<ProductBrand>> GetProductBrands(int id)
        {
            return Ok(await _repo.GetProductBrandsAsync());
        }
             [HttpGet("types")]
        public async Task<ActionResult<ProductType>> GetProductTypes(int id)
        {
            return Ok(await _repo.GetProductTypesAsync());
        }
    }
}