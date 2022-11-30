using System.ComponentModel.DataAnnotations.Schema;

namespace LP3_ProjetoFinal.Models;

public class Film
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public string Description { get; set; }
    // public string Duration { get; set; }
    public int Ticket { get; set; }
    // public string Session { get; set; }
    [ForeignKey("MovieTheater")]
    public int MovieTheaterId { get; set; }
    
    public Film() { }

    public Film(int id, string title, string director, string description, int ticket, int movieTheaterId)
    {
        Id = id;
        Title = title;
        Director = director;
        Description = description;
        Ticket = ticket;
        MovieTheaterId = movieTheaterId;
    }    
}
