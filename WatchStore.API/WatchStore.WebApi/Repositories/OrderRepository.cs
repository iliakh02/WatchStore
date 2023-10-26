using WatchStore.WebApi.Entities;
using WatchStore.WebApi.Repositories.Abstract;

namespace WatchStore.WebApi.Repositories;

public class OrderRepository : RepositoryBase<Order>, IOrderRepository
{
    public OrderRepository(WatchStoreDbContext repositoryContext)
        :base(repositoryContext)
    {
    }
}