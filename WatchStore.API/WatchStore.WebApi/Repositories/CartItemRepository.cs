using WatchStore.WebApi.Entities;
using WatchStore.WebApi.Repositories.Abstract;

namespace WatchStore.WebApi.Repositories;

public class CartItemRepository : RepositoryBase<CartItem>, ICartItemRepository
{
    public CartItemRepository(WatchStoreDbContext repositoryContext)
        :base(repositoryContext)
    {
    }
}