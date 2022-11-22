using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace API_Apps_2_new.models.Services
{
    public class CustomerDataAccess : IDbAccess<Customer,int>
    {
        NorthwindContext context;

        public CustomerDataAccess(NorthwindContext context)
        {
            this.context = context;
        }
        async Task<IEnumerable<Customer>> IDbAccess<Customer, int>.GetAsync()
        {
            return await context.Customers.ToListAsync();
        }
    }
}
