namespace API_Apps.models.Services
{
    public class ProductDataAccess : IDbAccessService<Product, int>
    {

        eShoppingCodiContext context;

        public ProductDataAccess(eShoppingCodiContext context)
        {
            this.context = context;
        }
    
        Task<IEnumerable<Product>> IDbAccessService<Product, int>.CreateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IDbAccessService<Product, int>.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Product>> IDbAccessService<Product, int>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Product>> IDbAccessService<Product, int>.GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Product>> IDbAccessService<Product, int>.UpdateAsync(int id, Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
