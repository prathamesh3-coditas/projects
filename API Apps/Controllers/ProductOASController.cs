using API_Apps.models.Services;
using API_Apps.models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace API_Apps.Controllers
{
    [Route("api/[controller]")]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    [ApiController]
    public class ProductOASController : Controller
    {
        IDbAccessService<Product, int> prodDbAccess;

        public ProductOASController(IDbAccessService<Product, int> prodDbAccess)
        {
            this.prodDbAccess = prodDbAccess;
        }
        /// <summary>
        /// MOdify the HTTP Action Method to
        /// return Managed Object Instead of HttpResponseMessage (IActionResult)
        /// </summary>
        /// <returns></returns>
        [HttpGet("/getproducts")]
        public async Task<IEnumerable<Product>> Get()
        {
            var result = await prodDbAccess.GetAsync();
            return result;
        }

        [HttpPost("/createProduct")]
        public async Task<Product> Post(Product product)
        {
            var result = await prodDbAccess.CreateAsync(product);
            return result;
        }

        [HttpPut("/UpdateProduct")]
        public async Task<Product> Update(Product cat)
        {
            int id = cat.ProductId;
            var Product = await prodDbAccess.GetAsync(id);
            return Product;
        }

        [HttpDelete("/DeleteProdut")]
        public async Task<bool> Delete(int id)
        {
            var isDeleted = await prodDbAccess.DeleteAsync(id);
            return isDeleted;
        }

        [HttpGet("/getProductById")]
        public async Task<IEnumerable<Product>> GetProductByCat(int id)
        {
            var prods = await prodDbAccess.GetAsyncByCatId(id);

            return prods;
        }
    }
}
