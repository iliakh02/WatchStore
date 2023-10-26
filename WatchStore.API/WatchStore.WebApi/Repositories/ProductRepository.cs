using WatchStore.WebApi.Entities;
using WatchStore.WebApi.Repositories.Abstract;

namespace WatchStore.WebApi.Repositories;

public class ProductRepository : RepositoryBase<Product>, IProductRepository
{
    public ProductRepository(WatchStoreDbContext repositoryContext)
        :base(repositoryContext)
    {
    }
}