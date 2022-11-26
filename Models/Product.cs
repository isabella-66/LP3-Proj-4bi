using System.ComponentModel.DataAnnotations.Schema;

namespace LP3_ProjetoFinal.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    [ForeignKey("Store")]
    public int StoreId { get; set; }
    public Store Store { get; set; }

    public Product() { }

    public Product(int id, string name, float price, string description, int quantity)
    {
        Id = id;
        Name = name;
        Price = price;
        Description = description;
        Quantity = quantity;
    }
    
}
