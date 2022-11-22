using Microsoft.EntityFrameworkCore;

namespace API_Apps_2_new.models.Services
{
    public class OrderDataAccess : IDbAccess<Order, int>
    {
        NorthwindContext context;

        public OrderDataAccess(NorthwindContext context)
        {
            this.context = context;
        }

        async Task<IEnumerable<Order>> IDbAccess<Order, int>.GetAsync()
        {
            return await context.Orders.ToListAsync();        
        }
    }
}
