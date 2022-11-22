using API_Apps.models;
using API_Apps.models.Services;
using API_Apps.Session;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace API_Apps.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class Assign1511Controller : Controller
    {

        IDbAccessService<Catagory, int> cats;
        IDbAccessService<Product, int> prods;


        public Assign1511Controller(IDbAccessService<Catagory, int> cats, IDbAccessService<Product, int> prods)
        {
            this.cats = cats;
            this.prods = prods;
        }


        //static int count = 0;
        //string tempData = null;
        [HttpGet]
        public async Task<IActionResult> GetData(string name, int recordNumber)
        {
            int count = 0;
            if (HttpContext.Session.GetObject<int>($"{name}") != 0)
            {
                count = HttpContext.Session.GetObject<int>($"{name}");
            }
            else
            {
                count = 0;
            }

            var catagory = (await cats.GetAsync()).Where(a => a.CatagoryName.Equals(name)).ToList();

            var id = catagory[0].CatagoryId;


            var products = (from product in (await prods.GetAsync())
                            where product.CatagoryId == id
                            select new
                            {
                                productId = product.ProductId,
                                productName = product.ProductName,
                                price = product.Price,
                                description = product.Description,
                                categoryId = product.CatagoryId

                            }).ToList().Skip(count).Take(recordNumber);



            if (products.Count() != 0)
            {
                count = count + recordNumber;
                HttpContext.Session.SetObject($"{name}", count);
            }
   


            return Ok(products);
        }

    }
}


