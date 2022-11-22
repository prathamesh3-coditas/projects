using Coditas_MVCApps1_DataAccess.models;
using Coditas_MVCApps1_Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;

namespace MVCApps1.Controllers
{
    public class CombineController : Controller
    {

        IDbRepository<Catagory, int> catRepo;
        IDbRepository<Product, int> prodRepo;
        Tuple<List<Catagory>, List<Product>> CombineList;
        public CombineController(IDbRepository<Catagory, int> catRepo, IDbRepository<Product, int> prodRepo)
        {
            this.catRepo = catRepo;
            this.prodRepo = prodRepo;
        }


        public async Task<IActionResult> Index(int? id)
        {

            List<Catagory> catagories = null;
            List<Product> products = null;
            catagories = (await catRepo.GetAsync()).ToList();

            if (id==null || id==0)
            {
                products = (await prodRepo.GetAsync()).ToList();
            }
            else
            {
                products = (from prod in (await prodRepo.GetAsync()) where prod.CatagoryId == id select prod).ToList();

            }

            CombineList = new Tuple<List<Catagory>, List<Product>>(catagories,products);

            return View(CombineList);
        }


        public async Task<IActionResult> IndexTagHelper()
        {
            var cats = await catRepo.GetAsync();
            var prods = await prodRepo.GetAsync();

            Tuple<IEnumerable<Catagory>, IEnumerable<Product>> tuple = new Tuple<IEnumerable<Catagory>, IEnumerable<Product>>(cats,prods);

            return View(tuple);
        }

        public IActionResult ShowDetails(int catId)
        {
            return RedirectToAction("Index", new { id = catId });
        }
    }
}
