using System.Linq.Expressions;

namespace WatchStore.WebApi.Repositories.Abstract;

public interface IRepositoryBase<T>
{
    T? GetById(int id);
    IQueryable<T> GetAll();
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    void Save();
}