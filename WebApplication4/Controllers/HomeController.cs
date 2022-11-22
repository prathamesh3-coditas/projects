using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication4.Models;
using ClientNS;
using System.Transactions;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ClientProxy proxy;
        HttpClient client;
        string baseURL = string.Empty;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            baseURL = "https://localhost:7183";
            client = new HttpClient();
            proxy = new ClientProxy(baseURL, client);
        }

        public async Task<IActionResult> Index()
        {
            var cats =await  proxy.GetcatagoriesAsync();
            ViewBag.result = cats;
            return View();
        }

        public async Task<IActionResult> getProds(Catagory id)
        {
            var prods = await proxy.GetProductByIdAsync(id.CatagoryId);

            return View(prods);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}