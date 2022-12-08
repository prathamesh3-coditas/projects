using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text.Json;
using Quiz_App.Models;
using Quiz_App.Models.Services;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Quiz_App.Controllers
{
    [Authorize]
    public class SearchController : Controller
    {

        IDbService<SearchTable,int> dbService;


        public SearchController(IDbService<SearchTable, int> bService)
        {
            dbService = bService;
        }

        public async Task<IActionResult> Index()
        {
            return View();   
        }
        
        
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> SearchProducts()
        {
            return View();
        }

       [HttpPost]
        public async Task<IActionResult> SearchProducts(string values)
        {
            string[] myArr = values.Split(',');

            IEnumerable<SearchTable> prods = await dbService.getAllProds();
            List<SearchTable> res = new List<SearchTable>();
            foreach (var item in myArr)
            {
                prods = prods.Where(a => (a.ProductName.Contains(item)) 
                || (a.ManufacturerName.Contains(item)) 
                || (a.Seller.Contains(item)) 
                || (a.Description.Contains(item)));



            }
            foreach (var item1 in prods)
            {
                res.Add(item1);
            }
            return View(res);
        }
    }
}
