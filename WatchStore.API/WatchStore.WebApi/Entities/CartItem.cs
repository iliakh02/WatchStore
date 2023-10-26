using System.ComponentModel.DataAnnotations;

namespace WatchStore.WebApi.Entities;

public class CartItem
{
    [Key]
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int CartId { get; set; }
}