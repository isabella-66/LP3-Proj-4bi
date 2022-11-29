using System.ComponentModel.DataAnnotations;

namespace LP3_ProjetoFinal.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string Occupation { get; set; }
    public int EntryTime { get; set; }
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