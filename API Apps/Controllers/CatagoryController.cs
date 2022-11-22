using API_Apps.models;
using API_Apps.models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Writers;

namespace API_Apps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatagoryController : ControllerBase
    {
        IDbAccessService<Catagory, int> access;

        public CatagoryController(IDbAccessService<Catagory, int> access)
        {
            this.access = access;
        }


        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var res = await access.GetAsync();
            return Ok(res);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var res = await access.GetAsync(id);
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Catagory cat)
        {
            if (ModelState.IsValid)
            {
                var isCatagoryExists = (await access.GetAsync())
                                        .Where(e => e.CatagoryName == cat.CatagoryName)
                                        .FirstOrDefault();

                if (isCatagoryExists != null)
                {
                    return Conflict($"Catagory named {cat.CatagoryName} already exists");
                }
                var res = await access.CreateAsync(cat);
                return Ok(res);

            }

            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await access.DeleteAsync(id);
            return Ok(res);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id , Catagory cat)
        {
            var res = await access.UpdateAsync(id, cat);
            return Ok(res); 
        }
    }
}
