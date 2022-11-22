using Coditas_MVCApps1_DataAccess.models;
using Coditas_MVCApps1_Entities;
using Coditas_MVCApps1_Repository;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace MVCApps1.Controllers
{
    public class ProdCatController : Controller
    {
        IDbRepository<Catagory, int> catRepo;
        IDbRepository<Product, int> prodRepo;

        public ProdCatController(IDbRepository<Catagory, int> catRepo, IDbRepository<Product, int> prodRepo)
        {
            this.catRepo = catRepo;
            this.prodRepo = prodRepo;
        }

        public async Task<IActionResult> Index()
        {
            var cats = await catRepo.GetAsync();
            return View(cats);
        }

        public async Task<IActionResult> Details(int id)
        {
            CatagoryProducts catProd = new CatagoryProducts();

           
            catProd.catInfo =  await catRepo.GetAsync(id);
            catProd.Products = prodRepo.GetProds(id);

            return View(catProd);

        }
    }
}
