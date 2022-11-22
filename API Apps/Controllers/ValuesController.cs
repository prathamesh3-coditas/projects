using API_Apps.CustomValidator;
using API_Apps.models;
using API_Apps.models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Apps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IDbAccessService<Catagory, int> cat;
        IDbAccessService<Product, int> prod;

        public ValuesController(IDbAccessService<Catagory, int> cat, IDbAccessService<Product, int> prod)
        {
            this.cat = cat;
            this.prod = prod;
        }

        [HttpGet("/getcatagories")]
        public async Task<IEnumerable<Catagory>> Get()
        {

            var cats = await cat.GetAsync();
            return cats;
        }


        [HttpPost("/createcatagory")]
        public async Task<Catagory> Post(Catagory catag)
        {
            var res = await cat.CreateAsync(catag);
            return res;
        }
    }
}
