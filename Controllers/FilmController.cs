using Microsoft.AspNetCore.Mvc;
using LP3_ProjetoFinal.Models;

namespace LP3_ProjetoFinal.Controllers;

public class FilmController : Controller
{
    private readonly ProjContext _context;

    public FilmController(ProjContext context) 
    {
        _context = context;
    }

    public IActionResult Index() => View(_context.Films);

    public IActionResult Show(int id) {
        Film film = _context.Films.Find(id);

        if(film == null)
        {
            return NotFound();
        }

        return View(film);
    }

    public IActionResult Create()
    {
        return View();
    }  

    [HttpPost]
    public IActionResult Create([FromForm] Film film)
    {
        if (!ModelState.IsValid)
        {
            return View(film);
        }

        if (_context.Films.Find(film.Id) != null) 
        {
            throw new Exception("Já existe um filme com esse Id");
        }

        _context.Films.Add(film);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Update(int id)
    {
        Film film = _context.Films.Find(id);
        return View(film);
    }

    [HttpPost]
    public IActionResult Update([FromForm] Film film)
    {
        Film filmFound = _context.Films.Find(film.Id);

        if (filmFound == null)
        {
            return NotFound();
        }

        filmFound.Id = film.Id;
        filmFound.Title = film.Title;
        filmFound.Director = film.Director;
        filmFound.Description = film.Description;
        filmFound.Ticket = film.Ticket;
        filmFound.DaySession = film.DaySession;
        filmFound.MonthSession = film.MonthSession;
        filmFound.HourSession = film.HourSession;
        filmFound.MovieTheater = film.MovieTheater;

        _context.Films.Update(filmFound);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Film film = _context.Films.Find(id);

        if(film == null)
        {
            return NotFound();
        }

        _context.Films.Remove(film);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}