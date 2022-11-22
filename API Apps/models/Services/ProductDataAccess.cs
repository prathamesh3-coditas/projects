using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Apps.models.Services
{
    public class ProductDataAccess : IDbAccessService<Product, int>
    {
        eShoppingCodiContext context;

        public ProductDataAccess(eShoppingCodiContext context)
        {
            this.context = context;
        }

        async Task<Product> IDbAccessService<Product, int>.CreateAsync(Product entity)
        {
            try
            {
                var result = await context.Products.AddAsync(entity);
                await context.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        async Task<bool> IDbAccessService<Product, int>.DeleteAsync(int id)
        {
            var deletedRecord = await context.Products.FindAsync(id);

            try
            {
                if (deletedRecord == null)
                {
                    throw new Exception();
                }
                context.Products.Remove(deletedRecord);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Record not deleted...!!!");
            }
        }

        async Task<IEnumerable<Product>> IDbAccessService<Product, int>.GetAsync()
        {
            return await context.Products.ToListAsync();

        }

        async Task<Product> IDbAccessService<Product, int>.GetAsync(int id)
        {
            try
            {
                var foundResult = await context.Products.FindAsync(id);
                return foundResult;

            }
            catch (Exception)
            {

                throw new Exception("Record not found...!!!");
            }
        }

        async Task<IEnumerable<Product>> IDbAccessService<Product, int>.GetAsyncByCatId(int id)
        {
            try
            {
                var foundResult = await context.Products.FindAsync(id);
                var result = from records in context.Products
                             where records.CatagoryId == id
                             select records;
                return result;

            }
            catch (Exception)
            {

                throw new Exception("Record not found...!!!");
            }
        }
        async Task<Product> IDbAccessService<Product, int>.UpdateAsync(int id, Product entity)
        {
            var recordToUpdate = await context.Products.FindAsync(id);

            try
            {

                recordToUpdate.ProductName = entity.ProductName;
                recordToUpdate.ProductId = entity.ProductId;
                recordToUpdate.ManufacturerId = entity.ManufacturerId;

                return recordToUpdate;
            }
            catch (Exception)
            {

                throw new Exception("Record not found...!!!");
            }
        }
    }
}

