using WatchStore.WebApi.Entities;

namespace WatchStore.WebApi.Services.Abstract;

public interface IProductsService
{
    List<Product> GetProducts();
    Product? GetProductById(int id);
}