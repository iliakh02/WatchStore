using System.Linq.Expressions;
using WatchStore.WebApi.Entities;
using WatchStore.WebApi.Repositories.Abstract;
using WatchStore.WebApi.Services.Abstract;

namespace WatchStore.WebApi.Services;

public class CartService : ICartService
{
    private readonly ICartItemRepository _cartItemRepository;

    public CartService(ICartItemRepository cartItemRepository)
    {
        _cartItemRepository = cartItemRepository;
    }
    
    public List<CartItem> GetCartItems(int userId = 1)
    {
        return _cartItemRepository.GetAll().Where(cartItem => cartItem.CartId == 1).ToList();
    }

    public void RemoveItemById(int id)
    {
        var item = _cartItemRepository.GetById(id);
        if (item is null)
        {
            throw new NullReferenceException("Cart item was not found");
        }
        
        _cartItemRepository.Delete(item);
        _cartItemRepository.Save();
    }

    public void AddItem(CartItem item)
    {
        _cartItemRepository.Add(item);
        _cartItemRepository.Save();
    }
}