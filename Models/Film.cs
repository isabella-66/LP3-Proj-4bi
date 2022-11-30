using System.ComponentModel.DataAnnotations.Schema;

namespace LP3_ProjetoFinal.Models;

public class Film
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public string Description { get; set; }
    public int Ticket { get; set; }
    public int DaySession { get; set; }
    public string MonthSession { get; set; }
    public int HourSession { get; set; }
    // [ForeignKey("MovieTheater")]
    public int MovieTheater { get; set; }
    
    public Film() { }

    public Film(int id, string title, string director, string description, int ticket, int daySession, string monthSession, int hourSession, int movieTheater)
    {
        Id = id;
        Title = title;
        Director = director;
        Description = description;
        Ticket = ticket;
        DaySession = daySession;
        MonthSession = monthSession;
        HourSession = hourSession;
        MovieTheater = movieTheater;
    }    
}
