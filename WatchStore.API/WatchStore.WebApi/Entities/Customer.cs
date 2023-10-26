using System.ComponentModel.DataAnnotations;

namespace WatchStore.WebApi.Entities;

public class Customer
{
    [Key] 
    public int Id { get; set; }
    [Required] 
    public string? Name { get; set; }
    [Required] 
    public string? Surname { get; set; }
    [Required] 
    public string? PhoneNumber { get; set; }
    [Required] 
    public string? DeliveryAddress { get; set; }
    
    public int CartId { get; set; }

    public ICollection<Order> Orders { get; set; }
}