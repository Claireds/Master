using SqlSugar;
using System.Linq.Expressions;
namespace MyBlog.IRepository
{
    public interface IBaseRepository<TEntity> where TEntity : class,new()
    {
        Task<TEntity> CreateAsync(TEntity entity);

        Task<bool> UpdateAsync(TEntity entity);

        Task<bool> DeleteAsync(int id);
       
        Task<TEntity> GetByIdAsync(int id);

        Task<List<TEntity>> QueryAsync();

        Task<List<TEntity>> QueryAsync(Expression<Func<TEntity,bool>> func);

        Task<List<TEntity>> QueryAsync(int page, int pageSize,RefAsync<TEntity> Total);
    }
}
