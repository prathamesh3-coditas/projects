using API_Apps_2_new.models;
using API_Apps_2_new.models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace API_Apps_2_new.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IDbAccess<Customer, int> cust;
        IDbAccess<Product, int> prod;
        IDbAccess<Order, int> ord;
        IDbAccess<OrderDetail, int> ordDetail;

        public ValuesController(IDbAccess<Customer, int> cust, IDbAccess<Product, int> prod,
           IDbAccess<Order, int> ord, IDbAccess<OrderDetail, int> ordDetail)
        {
            this.cust = cust;
            this.prod = prod;
            this.ord = ord;
            this.ordDetail = ordDetail;
        }


        [HttpGet]
        [ActionName("GetCustomerData")]
        public async Task<IActionResult> GetCustData()
        {

            string str1 = "Chai",
                str2 = "Geitost";

            var custData = (from order in (await ord.GetAsync())
                            join details in (await ordDetail.GetAsync())
                            on order.OrderId equals details.OrderId
                            join product in (await prod.GetAsync())
                            on details.ProductId equals product.ProductId
                            where product.ProductName == str1 || product.ProductName == str2
                            select new
                            {
                                name = product.ProductName,
                                id = order.CustomerId
                            }).ToList();

            return Ok(custData);


        }

        //===============================================
        [HttpGet]
        [ActionName("TotalOrders")]

        public async Task<IActionResult> GetOrderDetails()
        {
            var prodData = from product in (await prod.GetAsync())
                           join details in (await ordDetail.GetAsync())
                           on product.ProductId equals details.ProductId
                           join order in (await ord.GetAsync())
                           on details.OrderId equals order.OrderId
                           group details by order.CustomerId
                           into grps
                           select new
                           {
                               custId = grps.Key,
                               eachProdCount = grps.Sum(a=>a.Quantity)
                           };

            return Ok(prodData);
            
        }

        [HttpGet]
        [ActionName("CitiesWithMaxOrders")]
        public async Task<IActionResult> Getcities()
        {
            
        }

    }
}
