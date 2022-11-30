using System.ComponentModel.DataAnnotations;

namespace LP3_ProjetoFinal.Models;

public class Employee
{
    [Required]
    public int Id { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    [StringLength(120)]
    public string Lastname { get; set; }
    [Required]
    [StringLength(80)]
    public string Occupation { get; set; }
    [Required]
    public int EntryTime { get; set; }
    [Required]
    public int DepartureTime { get; set; }

    public Employee() { }

    public Employee(int id, string name, string lastname, string occupation, int entryTime, int departureTime)
    {
        Id = id;
        Name = name;
        Lastname = lastname;
        Occupation = occupation;
        EntryTime = entryTime;
        DepartureTime = departureTime;
    }
}