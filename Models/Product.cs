using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LP3_ProjetoFinal.Models;

public class Product
{
    [Required]
    public int Id { get; set; }

    [StringLength(20)]
    [Required]
    public string Name { get; set; }

    [Required]
    [Range(0.1, 9999)]
    public float Price { get; set; }

    [Required]
    [StringLength(200)]
    public string Description { get; set; }

    [Required]
    [Range(1, 1000)]
    public int Quantity { get; set; }

    [ForeignKey("Store")]
    [Required]
    public int StoreId { get; set; }
    
    public Store Store { get; set; }

    public Product() { }

    public Product(int id, string name, float price, string description, int quantity, int storeId)
    {
        Id = id;
        Name = name;
        Price = price;
        Description = description;
        Quantity = quantity;
        StoreId = storeId;
    }
}
