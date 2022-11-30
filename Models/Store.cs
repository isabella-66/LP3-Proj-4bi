using System.ComponentModel.DataAnnotations;

namespace LP3_ProjetoFinal.Models;

public class Store
{
    [Required]
    public int Id { get; set; }

    [Required]
    [StringLength(20)]
    public string Name { get; set; }

    [Required]
    [StringLength(200)]
    public string Description { get; set; }

    public Store() { }

    public Store(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
}
