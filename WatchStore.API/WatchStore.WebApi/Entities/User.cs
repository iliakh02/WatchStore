using System.ComponentModel.DataAnnotations;

namespace WatchStore.WebApi.Entities;

public class User
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Login { get; set; }
    [Required]
    public string? Password { get; set; }
    [Required]
    public Role? Role { get; set; }
}