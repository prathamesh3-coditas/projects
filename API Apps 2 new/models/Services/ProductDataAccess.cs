using Microsoft.EntityFrameworkCore;

namespace API_Apps_2_new.models.Services
{
    public class ProductDataAccess : IDbAccess<Product, int>
    {

        NorthwindContext context;

        public ProductDataAccess(NorthwindContext context)
        {
            this.context = context;
        }

         async Task<IEnumerable<Product>> IDbAccess<Product, int>.GetAsync()
        {
            return await context.Products.ToListAsync();
        }
    }
}
