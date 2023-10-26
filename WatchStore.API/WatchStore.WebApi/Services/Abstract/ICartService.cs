using WatchStore.WebApi.Entities;

namespace WatchStore.WebApi.Services.Abstract;

public interface ICartService
{
    List<CartItem> GetCartItems(int userId = 1);
    void RemoveItemById(int id);
    void AddItem(CartItem item);
}