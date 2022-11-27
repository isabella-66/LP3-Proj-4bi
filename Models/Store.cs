namespace LP3_ProjetoFinal.Models;

public class Store
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public Store() { }

    public Store(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
    
}
