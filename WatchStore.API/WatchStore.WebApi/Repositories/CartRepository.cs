using WatchStore.WebApi.Entities;
using WatchStore.WebApi.Repositories.Abstract;

namespace WatchStore.WebApi.Repositories;

public class CartRepository : RepositoryBase<Cart>, ICartRepository
{
    public CartRepository(WatchStoreDbContext repositoryContext)
        :base(repositoryContext)
    {
    }
}