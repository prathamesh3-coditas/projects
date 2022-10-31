namespace API_Apps.models.Services
{
    public interface IDbAccessService<TEntity , in TPk> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync();
        Task<IEnumerable<TEntity>> GetAsync(TPk id);
        Task<IEnumerable<TEntity>> CreateAsync(TEntity entity);
        Task<IEnumerable<TEntity>> UpdateAsync(TPk id,TEntity entity);
        Task<bool> DeleteAsync(TPk id);


    }
}
