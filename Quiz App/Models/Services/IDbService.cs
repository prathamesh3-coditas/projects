namespace Quiz_App.Models.Services
{
    public interface IDbService<TEntity,in TPk> where TEntity : class 
    {
        Task<IEnumerable<object>> SearchAsync(List<string> list);
        Task<IEnumerable<TEntity>> getAllProds();
    }
}
