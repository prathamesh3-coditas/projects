using API_Apps.models;
using API_Apps.models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace API_Apps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IDbAccessService<Product,int> dbAccessService;

        public ProductController(IDbAccessService<Product, int> dbAccessService)
        {
            this.dbAccessService = dbAccessService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var res = await dbAccessService.GetAsync();
            return Ok(res);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var res = await dbAccessService.GetAsync(id);
            return Ok(res);
        }


        [HttpPost]
        public async Task<IActionResult> CreateAsync(Product prod)
        {

            if (ModelState.IsValid)
            {
                var res = await dbAccessService.CreateAsync(prod);
                return Ok(res);
            }

            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var res = await dbAccessService.DeleteAsync(id);
            return Ok(res);           
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(int id, Product prod)
        {
            var res = await dbAccessService.UpdateAsync(id, prod);
            return Ok(res);
        }
    }
}
