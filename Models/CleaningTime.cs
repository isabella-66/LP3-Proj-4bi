namespace LP3_ProjetoFinal.Models;

public class CleaningTime
{
    public int Id { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
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
