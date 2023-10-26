using WatchStore.WebApi.Entities;

namespace WatchStore.WebApi.Services;

public interface IProductsService
{
    List<Product> GetProducts();
    Product? GetProductById(int id);
}