using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WatchStore.WebApi.Repositories.Abstract;

namespace WatchStore.WebApi.Repositories;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    private readonly WatchStoreDbContext _context;

    public RepositoryBase(WatchStoreDbContext context)
    {
        _context = context;
    }

    public T? GetById(int id) => _context.Set<T>().Find(id);

    public IQueryable<T> GetAll() => _context.Set<T>().AsNoTracking();

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
        _context.Set<T>().Where(expression).AsNoTracking();

    public void Add(T entity) => _context.Set<T>().Add(entity);

    public void Update(T entity) => _context.Set<T>().Update(entity);

    public void Delete(T entity) => _context.Set<T>().Remove(entity);
}