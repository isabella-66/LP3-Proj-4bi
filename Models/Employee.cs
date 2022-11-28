using System.ComponentModel.DataAnnotations;

namespace LP3_ProjetoFinal.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime Birth { get; set; }
    public string Occupation { get; set; }
    public TimeOnly EntryTime { get; set; }
    public TimeOnly DepartureTime { get; set; }

    public Employee() { }

    public Employee(int id, string name, string lastname, DateTime birth, string occupation, TimeOnly entryTime, TimeOnly departureTime)
    {
        Id = id;
        Name = name;
        Lastname = lastname;
        Birth = birth;
        Occupation = occupation;
        EntryTime = entryTime;
        DepartureTime = departureTime;
    }
}