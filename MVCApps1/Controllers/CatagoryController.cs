using Microsoft.AspNetCore.Mvc;
using Coditas_MVCApps1_DataAccess;
using Coditas_MVCApps1_Repository;
using Coditas_MVCApps1_DataAccess.models;
using MVCApps1.Session;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MVCApps1.Controllers
{
    public class CatagoryController : Controller
    {

        IDbRepository<Catagory, int> catRepo;

        public CatagoryController(IDbRepository<Catagory, int> catRepo)
        {
            this.catRepo = catRepo;
        }



        public async Task<IActionResult> Index()
        {
  
                var data = await catRepo.GetAsync();
                return View(data);

        }


        public async Task<IActionResult> IndexTagHelper()
        {
            var cats = await catRepo.GetAsync();
            return View(cats);
        }

        public async Task<IActionResult> Create()
        {

            var cat = new Catagory();
           
            if (TempData.Count != 0)
            {
                cat.CatagoryId = Convert.ToInt32(TempData["CatagoryId"]);
                cat.CatagoryName = TempData["CatagoryName"].ToString();
                cat.BasePrice = Convert.ToInt32(TempData["BasePrice"]);
                ViewBag.msg = "Put some valid Price...!!!";

            }
            return View(cat);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Catagory cat)
        {
            if (ModelState.IsValid)
            {
                if (cat.BasePrice < 0)
                {
                    TempData["CatagoryId"] = cat.CatagoryId;
                    TempData["CatagoryName"] = cat.CatagoryName;
                    TempData["BasePrice"] = cat.BasePrice;

                    //TempData["Catagory"] = cat;



                    throw new Exception("Base price can not be negavtive...!!!");
                }

                var data = await catRepo.CreateAsync(cat);

                return RedirectToAction("Index");
            }

            return View("Error");

        }

        public async Task<IActionResult> Edit(int id)
        {
            var record = await catRepo.GetAsync(id);
            return View(record);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Catagory cat)
        {
            var updated = await catRepo.UpdateAsync(id, cat);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var record = await catRepo.GetAsync(id);
            return View(record);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var deleted = await catRepo.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var record = await catRepo.GetAsync(id);
            return RedirectToAction("ShowDetails");
        }


        public async Task<IActionResult> ShowDetails(int id)
        {
            //Catagory id is set from here
            HttpContext.Session.SetInt32("CatagoryId", id);

            var catagory = await catRepo.GetAsync(id);

            HttpContext.Session.SetObject<Catagory>("Cat", catagory);

            return RedirectToAction("Index", "Product");

        }
    }
}
