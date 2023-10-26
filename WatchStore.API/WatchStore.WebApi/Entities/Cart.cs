using System.ComponentModel.DataAnnotations;

namespace WatchStore.WebApi.Entities;

public class Cart
{
    [Key]
    public int Id { get; set; }
    public ICollection<CartItem> CartItems { get; set; }
}