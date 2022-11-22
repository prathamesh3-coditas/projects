namespace API_Apps_2_new.models.Services
{
    public interface IDbAccess<TEntity , in TPk> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync();
    }
}
