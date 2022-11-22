using Microsoft.EntityFrameworkCore;

namespace API_Apps_2_new.models.Services
{
    public class OrderDetailsDataAccess : IDbAccess<OrderDetail, int>
    {

        NorthwindContext context;

        public OrderDetailsDataAccess(NorthwindContext context)
        {
            this.context = context;
        }

        async Task<IEnumerable<OrderDetail>> IDbAccess<OrderDetail, int>.GetAsync()
        {
            return await context.OrderDetails.ToListAsync();
        }
    }
}
