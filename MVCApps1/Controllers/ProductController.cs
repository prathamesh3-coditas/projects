using Coditas_MVCApps1_DataAccess.models;
using Coditas_MVCApps1_Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.CodeAnalysis.CSharp;
using MVCApps1.Session;
using System.Security.Permissions;

namespace MVCApps1.Controllers
{
	public class ProductController : Controller
	{
		IDbRepository<Product, int> prdRepo;


		public ProductController(IDbRepository<Product,int> prdRepo)
		{
			this.prdRepo = prdRepo;
		}
		public async Task<IActionResult> Index()
		{
			IEnumerable<Product> products;
			int catId = Convert.ToInt32(HttpContext.Session.GetInt32("CatagoryId"));


				if (catId==0)
				{
					 products = await prdRepo.GetAsync();
				}
				else
				{
					products = (await prdRepo.GetAsync()).Where(a=>a.CatagoryId==catId).ToList();

				}

				return View(products);

	
		}

		public async Task<IActionResult> IndexTagHelper()
		{
			var prod = await prdRepo.GetAsync();
			return View(prod);
		}

		public async Task<IActionResult> Create()
		{
			var record = new Product();
			return View(record);


		}

		[HttpPost]
		public async Task<IActionResult> Create(Product prd)
		{
			var data = await prdRepo.CreateAsync(prd);
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Edit(int id)
		{
			var record = await prdRepo.GetAsync(id);
			return View(record);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id,Product prd)
		{
			var edited = await prdRepo.UpdateAsync(id, prd);
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Delete(int id)
		{
			var record = await prdRepo.DeleteAsync(id);
			return View(record);
		}

		public async Task<IActionResult> DeleteConfirm(int id)
		{
			await prdRepo.DeleteAsync(id);
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Details(int id)
		{
			var record = await prdRepo.GetAsync(id);
			return View(record);
		}
	}
}
 