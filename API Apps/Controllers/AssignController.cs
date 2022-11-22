using API_Apps.models;
using API_Apps.models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace API_Apps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignController : ControllerBase
    {
        IDbAccessService<Product, int> prod;
        IDbAccessService<Catagory, int> cat;

        public AssignController(IDbAccessService<Product, int> prod, IDbAccessService<Catagory, int> cat)
        {
            this.prod = prod;
            this.cat = cat;
        }

        [HttpGet]
        public async Task<IActionResult> Search(int catId,int prodId)
        {
            if (catId==0)
            {
                var resProd = await prod.GetAsync(prodId);
                return Ok(resProd);

            }
            else if (prodId==0)
            {
                var resCat = await cat.GetAsync(catId);
                var res = await prod.GetAsyncByCatId(resCat.CatagoryId);
                return Ok(res);
            }
            else
            {
                var takenprods = await prod.GetAsync();
                var takenCats = await cat.GetAsync();

                var bothInputs = from product in takenprods
                                 join catagory in takenCats
                                 on product.CatagoryId equals catagory.CatagoryId
                                 where product.ProductId == prodId && catagory.CatagoryId == catId
                                 select new
                                 {
                                     productId = product.CatagoryId,
                                     productName = product.ProductName,
                                     catName = catagory.CatagoryName,
                                     productPrice = product.Price
                                 };


                return Ok(bothInputs);
            }
 
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromQuery]Catagory c,Product p)
        {
            await cat.CreateAsync(c);
            await prod.CreateAsync(p);

            return Ok();
        }
        

    }
}
