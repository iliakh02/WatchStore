using WatchStore.WebApi.Entities;
using WatchStore.WebApi.Repositories.Abstract;
using WatchStore.WebApi.Services.Abstract;

namespace WatchStore.WebApi.Services;

public class ProductsService : IProductsService
{
    private readonly IProductRepository _productRepository;

    public ProductsService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public List<Product> GetProducts()
    {
        return _productRepository.GetAll().ToList();
    }

    public Product? GetProductById(int id)
    {
        return _productRepository.GetById(id);
    }
}