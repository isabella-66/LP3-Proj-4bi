using System.ComponentModel.DataAnnotations;

namespace LP3_ProjetoFinal.Models;

public class Film
{
    [Required]
    public int Id { get; set; }
    [Required]
    [StringLength(40)]
    public string Title { get; set; }
    [Required]
    [StringLength(100)]
    public string Director { get; set; }
    [Required]
    [StringLength(500)]
    public string Description { get; set; }
    [Required]
    public int Ticket { get; set; }
    [Required]
    public int DaySession { get; set; }
    [Required]
    [StringLength(20)]
    public string MonthSession { get; set; }
    [Required]
    public int HourSession { get; set; }
    [Required]
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
