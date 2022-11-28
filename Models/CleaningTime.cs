using System.ComponentModel.DataAnnotations;
namespace LP3_ProjetoFinal.Models;

public class CleaningTime
{
    [Required]
    public int Id { get; set; }

    [Required]
    public TimeSpan StartTime { get; set; }

    [Required]
    public TimeSpan EndTime { get; set; }
    
    [Required]
    public string Employee { get; set; }

    public CleaningTime() { }

    public CleaningTime(int id, TimeSpan startTime, TimeSpan endTime, string employee)
    {
        Id = id;
        StartTime = startTime;
        EndTime = endTime;
        Employee = employee;
    }
}
