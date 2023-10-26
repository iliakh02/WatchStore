using System.ComponentModel.DataAnnotations;

namespace WatchStore.WebApi.Entities;

public class Product
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Description { get; set; }
    [Required]
    public string? ImgUrl { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public int TotalAmount { get; set; }
    [Required]
    public decimal Rating { get; set; }

    public ICollection<CartItem> CartItems { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}