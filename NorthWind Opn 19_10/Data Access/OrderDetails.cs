using NorthWind_Opn_19_10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind_Opn_19_10.Data_Access
{
    internal class OrderDetails
    {
        northwindContext context;
        public OrderDetails()
        {
            context = new northwindContext();
        }

        public void OrdersByCount()
        {
            var ordercount = from detail in context.Orders
                             group detail by detail.CustomerId
                             into grps
                             select new
                             {
                                 id = grps.Key,
                                 order_count = grps.Count()
                             };

            foreach (var item in ordercount)
            {
                Console.WriteLine($"Customer Id= {item.id} & Order count= {item.order_count}");
            }

        }

        public void Display()
        {
            var tri = from details in context.OrderDetails
                      join Order in context.Orders
                      on details.OrderId equals Order.OrderId
                      join cust in context.Customers
                      on Order.CustomerId equals cust.CustomerId
                      select new
                      {
                          Customer = cust.CustomerId,
                          CustomerName = cust.ContactName,
                          Order = Order.OrderId,
                          OrderPrice = details.UnitPrice,
                          OrderQuantity = details.Quantity
                      };



            //            foreach (var item in tri)
            //            {
            //                Console.WriteLine(@$"Customer ID :{item.Customer}
            //CustomerName :{item.CustomerName}
            //Order : {item.Order}
            //OrderPrice : {item.OrderPrice}
            //Quantity : {item.OrderQuantity}");
            //                Console.WriteLine("-----------------------");
            //            }

            var res = from cust in tri
                      group cust by cust.CustomerName
                      into grps
                      select new
                      {
                          grps.Key
                      };

            foreach (var item in res)
            {

            }
        }


    }
}
