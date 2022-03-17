using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models;

public class Shoe
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    public ShoeSize Size { get; set; }

    [Range(0.01, 9999.99)]
    public decimal Price { get; set; }
}

public enum ShoeSize { Small, Medium, Large }