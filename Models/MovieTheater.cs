using System.ComponentModel.DataAnnotations;
namespace LP3_ProjetoFinal.Models;

public class MovieTheater
{
    [Required]
    public int Id { get; set; }

    [Required]
    public int Number { get; set; }

    [Required]
    public int NumberSeats { get; set; }

    [Required]
    public string Hall { get; set; }

    public MovieTheater() { }

    public MovieTheater(int id, int number, int numberSeats, string hall)
    {
        Id = id;
        Number = number;
        NumberSeats = numberSeats;
        Hall = hall;
    }
}
