using WatchStore.WebApi.Data;
using WatchStore.WebApi.Models;

namespace WatchStore.WebApi.Services;

public class ProductsService : IProductsService
{
    public List<Product> GetProducts()
    {
        return DataMocker.GetProducts();
    }

    public Product? GetProductById(int id)
    {
        return DataMocker.GetProducts().FirstOrDefault(product => product.Id == id);
    }
}