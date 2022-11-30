using System.ComponentModel.DataAnnotations;

namespace LP3_ProjetoFinal.Models;

public class Film
{
    [Required (ErrorMessage = "Campo Id deve ser preenchido.")]
    public int Id { get; set; }
    [Required (ErrorMessage = "Campo Título deve ser preenchido.")]
    [StringLength(40)]
    public string Title { get; set; }
    [Required (ErrorMessage = "Campo Direção deve ser preenchido.")]
    [StringLength(100)]
    public string Director { get; set; }
    [Required (ErrorMessage = "Campo Sinopse deve ser preenchido.")]
    [StringLength(500)]
    public string Description { get; set; }
    [Required (ErrorMessage = "Campo Quantidade Ingressos deve ser preenchido.")]
    public int Ticket { get; set; }
    [Required (ErrorMessage = "Campo Dia da Sessão deve ser preenchido.")]
    public int DaySession { get; set; }
    [Required (ErrorMessage = "Campo Mês da Sessão deve ser preenchido.")]
    [StringLength(20)]
    public string MonthSession { get; set; }
    [Required (ErrorMessage = "Campo Ano da Sessão deve ser preenchido.")]
    public int HourSession { get; set; }
    [Required (ErrorMessage = "Campo Sala deve ser preenchido.")]
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
