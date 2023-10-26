using WatchStore.WebApi.Entities;
using WatchStore.WebApi.Repositories.Abstract;

namespace WatchStore.WebApi.Repositories;

public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
{
    public CustomerRepository(WatchStoreDbContext repositoryContext)
        :base(repositoryContext)
    {
    }
}