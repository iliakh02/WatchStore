using System.ComponentModel.DataAnnotations;

namespace WatchStore.WebApi.Entities;

public class Role
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }

    public ICollection<User> Users { get; set; }
}