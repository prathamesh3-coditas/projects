using Coditas_MVCApps1_DataAccess.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coditas_MVCApps1_Repository
{
    public class ProductRepository : IDbRepository<Product, int>
    {

        eShoppingCodiContext context;

        public ProductRepository(eShoppingCodiContext context)
        {
            this.context = context;
        }
        async Task<Product> IDbRepository<Product, int>.CreateAsync(Product entity)
        {
            var res = await context.Products.AddAsync(entity);
            await context.SaveChangesAsync();
            return res.Entity;
        }

        async Task<Product> IDbRepository<Product, int>.DeleteAsync(int id)
        {
            var record = await context.Products.FindAsync(id);

            if (record == null)
            {
                throw new Exception();
            }
            context.Products.Remove(record);
            await context.SaveChangesAsync();
            return record;
        }

        async Task<IEnumerable<Product>> IDbRepository<Product, int>.GetAsync()
        {
            return await context.Products.ToListAsync();
        }

        async Task<Product> IDbRepository<Product, int>.GetAsync(int id)
        {
            var record = await context.Products.FindAsync(id);

            if (record == null)
            {
                throw new Exception();
            }

            return record;
        }
        
        async Task<Product> IDbRepository<Product, int>.UpdateAsync(int id, Product entity)
        {
            var record = await context.Products.FindAsync(id);
            if (record == null)
            {
                throw new Exception();
            }

            record.ProductName = entity.ProductName;
            record.Manufacturer = entity.Manufacturer;
            record.Catagory = entity.Catagory;
            record.Description = entity.Description;
            record.Price = entity.Price;
            await context.SaveChangesAsync();
            return record;
        }



        IEnumerable<Product> IDbRepository<Product, int>.GetProds(int id)
        {
            var prods = from prd in context.Products where prd.CatagoryId == id select prd;
            context.SaveChangesAsync();
            return prods;
        }
    }
}
