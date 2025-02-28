using System.ComponentModel.DataAnnotations;

namespace AmazonOrderSystem.Models{
    public class User
    {
    public int UserID {get; set;}

    [Required]
    public string? Name {get; set;}

    [Required]
    public string? Email {get; set;}

    [Required]
    public string? Password {get; set;}

    public DateTime CreatedAt {get; set;} = DateTime.Now;
    }
}

