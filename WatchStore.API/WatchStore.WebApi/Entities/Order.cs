using System.ComponentModel.DataAnnotations;

namespace WatchStore.WebApi.Entities;

public class Order
{
    [Key]
    public int Id { get; set; }
    public decimal TotalPrice { get; set; }
    public bool IsPaid { get; set; }
    public Customer Customer { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}