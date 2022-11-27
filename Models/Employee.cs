namespace LP3_ProjetoFinal.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string Birth { get; set; }
    public string Occupation { get; set; }
    public TimeSpan EntryTime { get; set; }
    public TimeSpan DepartureTime { get; set; }

    public Employee() { }

    public Employee(int id, string name, string lastname, string birth, string occupation, TimeSpan entryTime, TimeSpan departureTime)
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