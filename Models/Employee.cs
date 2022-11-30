using System.ComponentModel.DataAnnotations;

namespace LP3_ProjetoFinal.Models;

public class Employee
{
    [Required (ErrorMessage = "Campo Id deve ser preenchido.")]
    public int Id { get; set; }
    [Required  (ErrorMessage = "Campo Nome deve ser preenchido.")]
    [StringLength(20)]
    public string Name { get; set; }
    [Required  (ErrorMessage = "Campo Sobrenome deve ser preenchido.")]
    [StringLength(120)]
    public string Lastname { get; set; }
    [Required  (ErrorMessage = "Campo Ocupação deve ser preenchido.")]
    [StringLength(80)]
    public string Occupation { get; set; }
    [Required  (ErrorMessage = "Campo Horário de Entrada deve ser preenchido.")]
    public int EntryTime { get; set; }
    [Required  (ErrorMessage = "Campo Horário de Saída deve ser preenchido.")]
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