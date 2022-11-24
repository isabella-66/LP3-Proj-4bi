namespace LP3_ProjetoFinal.Models;

public class MovieTheater
{
    public int Id { get; set; }
    public int Number { get; set; }
    public int NumberSeats { get; set; }
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
