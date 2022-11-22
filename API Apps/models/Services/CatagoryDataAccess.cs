
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Apps.models.Services
{
    public class CatagoryDataAccess : IDbAccessService<Catagory, int>
    {
        eShoppingCodiContext context;

        public CatagoryDataAccess(eShoppingCodiContext context)
        {
            this.context = context;
        }




        async Task<Catagory> IDbAccessService<Catagory, int>.CreateAsync(Catagory entity)
        {
            try
            {
                var result = await context.Catagories.AddAsync(entity);
                await context.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




        async Task<bool> IDbAccessService<Catagory, int>.DeleteAsync(int id)
        {
            var deletedRecord = await context.Catagories.FindAsync(id);
            if (deletedRecord == null)
            {
                throw new Exception();
            }

            try
            {
                context.Catagories.Remove(deletedRecord);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Record not deleted...!!!");
            }
        }




        async Task<Catagory> IDbAccessService<Catagory, int>.GetAsync(int id)
        {
            var foundResult = await context.Catagories.FindAsync(id);

            return foundResult;

        }




        async Task<IEnumerable<Catagory>> IDbAccessService<Catagory, int>.GetAsync()
        {
            return await context.Catagories.ToListAsync();
        }

        //===============================================================
        Task<IEnumerable<Catagory>> IDbAccessService<Catagory, int>.GetAsyncByCatId(int id)
        {
            throw new Exception();
        }

        async Task<Catagory> IDbAccessService<Catagory, int>.UpdateAsync(int id, Catagory entity)
        {
            var recordToUpdate = await context.Catagories.FindAsync(id);

            try
            {

                recordToUpdate.CatagoryName = entity.CatagoryName;
                recordToUpdate.CatagoryId = entity.CatagoryId;
                recordToUpdate.BasePrice = entity.BasePrice;

                context.SaveChanges();
                return recordToUpdate;
            }
            catch (Exception)
            {

                throw new Exception("Record not found...!!!");
            }
        }
    }
}
