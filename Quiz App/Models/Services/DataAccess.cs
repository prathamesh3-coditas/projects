using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.EntityFrameworkCore;

namespace Quiz_App.Models.Services
{
    public class DataAccess : IDbService<SearchTable, int>
    {
        EShoppingCodiContext context;
        
        public DataAccess(EShoppingCodiContext context)
        {
           this.context = context;
        }

        async Task<IEnumerable<SearchTable>> IDbService<SearchTable, int>.getAllProds()
        {
            var res = await context.SearchTables.ToListAsync();
            return res;
        }


        async Task<IEnumerable<object>> IDbService<SearchTable, int>.SearchAsync(List<string> list)
        {
            Type t = list.GetType();

            var data = await context.SearchTables.ToListAsync();

            var products = from prd in data
                           where list.Contains(prd.ProductName)
                           || list.Contains(prd.ManufacturerName)
                           || list.Contains(prd.Description)
                           || list.Contains(prd.Seller)
                           select prd;


            return products;
        }

      
    }
}
