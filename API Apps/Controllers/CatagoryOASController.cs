using API_Apps.models;
using API_Apps.models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;

namespace API_Apps.Controllers
{
    [Route("api/[controller]")]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    [ApiController]
    public class CatagoryOASController : ControllerBase
    {
        IDbAccessService<Catagory, int> catDbAccess;

        public CatagoryOASController(IDbAccessService<Catagory, int> catDbAccess)
        {
            this.catDbAccess = catDbAccess;
        }
        /// <summary>
        /// MOdify the HTTP Action Method to
        /// return Managed Object Instead of HttpResponseMessage (IActionResult)
        /// </summary>
        /// <returns></returns>
        [HttpGet("/getcategoties")]
        public async Task<IEnumerable<Catagory>> Get()
        {
            var result = await catDbAccess.GetAsync();
            return result;
        }

        [HttpPost("/createCatagory")]
        public async Task<Catagory> Post(Catagory Catagory)
        {
            var result = await catDbAccess.CreateAsync(Catagory);
            return result;
        }

        [HttpPut("/UpdateCatagory")]
        public async Task<Catagory> Update(Catagory cat)
        {
            int id = cat.CatagoryId;
            var catagory = await catDbAccess.UpdateAsync(id, cat);
            return catagory;
        }
        
        [HttpDelete("/DeleteCatagory")]
        public async Task<bool> Delete(int id)
        {
            var isDeleted = await catDbAccess.DeleteAsync(id);
            return isDeleted;
        }
    }
}