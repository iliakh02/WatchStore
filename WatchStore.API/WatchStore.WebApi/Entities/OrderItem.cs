using System.ComponentModel.DataAnnotations;

namespace WatchStore.WebApi.Entities;

public class OrderItem
{
    [Key]
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int OrderId { get; set; }
}