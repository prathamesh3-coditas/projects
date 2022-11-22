using Coditas_MVCApps1_DataAccess.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coditas_MVCApps1_Repository
{
    public class CatagoryRepository : IDbRepository<Catagory,int>
    {

        eShoppingCodiContext context;

        public CatagoryRepository(eShoppingCodiContext context)
        { 
            this.context = context;
        }

        async Task<Catagory> IDbRepository<Catagory, int>.CreateAsync(Catagory entity)
        {
            var res = await context.Catagories.AddAsync(entity);
            await context.SaveChangesAsync();

            return res.Entity;
        }

        async Task<Catagory> IDbRepository<Catagory, int>.DeleteAsync(int id)
        {
            var res = await context.Catagories.FindAsync(id);

            if (res == null)
            {
                throw new Exception();
            }

            try
            {
                context.Catagories.Remove(res);
                await context.SaveChangesAsync();
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }

        async Task<IEnumerable<Catagory>> IDbRepository<Catagory, int>.GetAsync()
        {
            return await context.Catagories.ToListAsync();
        }

        async Task<Catagory> IDbRepository<Catagory, int>.GetAsync(int id)
        {
            var record = await context.Catagories.FindAsync(id);
            if (record==null)
            {
                throw new Exception();
            }

            return record;
        }

        IEnumerable<Catagory> IDbRepository<Catagory, int>.GetProds(int id)
        {
            throw new NotImplementedException();
        }

        async Task<Catagory> IDbRepository<Catagory, int>.UpdateAsync(int id, Catagory entity)
        {
            var record = await context.Catagories.FindAsync(id);
            if (record == null)
            {
                throw new Exception();
            }

            //record.CatagoryId = entity.CatagoryId;
            record.CatagoryName = entity.CatagoryName;
            record.BasePrice = entity.BasePrice;

            await context.SaveChangesAsync();

            return record;
        }


        
    }
}
