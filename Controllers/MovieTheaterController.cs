using Microsoft.AspNetCore.Mvc;
using LP3_ProjetoFinal.Models;

namespace LP3_ProjetoFinal.Controllers;

public class MovieTheaterController : Controller
{
    private readonly ProjContext _context;

    public MovieTheaterController(ProjContext context) 
    {
        _context = context;
    }

    public IActionResult Index() => View(_context.MovieTheaters);

    public IActionResult Show(int id) {
        MovieTheater theater = _context.MovieTheaters.Find(id);

        if(theater == null)
        {
            return NotFound();
        }

        return View(theater);
    }

    public IActionResult Delete(int id)
    {
        MovieTheater theater = _context.MovieTheaters.Find(id);

        if(theater == null)
        {
            return NotFound();
        }

        _context.MovieTheaters.Remove(theater);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Update(int id)
    {
        MovieTheater theater = _context.MovieTheaters.Find(id);
        return View(theater);
    }

    [HttpPost]
    public IActionResult Update([FromForm] MovieTheater theater)
    {
        if (!ModelState.IsValid)
        {
            return View(theater);
        }
        
        _context.MovieTheaters.Update(theater);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Create()
    {
        return View();
    }  

    [HttpPost]
    public IActionResult Create([FromForm] MovieTheater theater)
    {
        if (!ModelState.IsValid)
        {
            return View(theater);
        }

        if (_context.CleaningTimes.Find(theater.Id) != null) 
        {
            throw new Exception($"Já existe uma sala cadastrado com o id {theater.Id}");
        }

        if (_context.CleaningTimes.Find(theater.Number) != null) 
        {
            throw new Exception($"Já existe uma sala cadastrada com o número {theater.Number}");
        }

        _context.MovieTheaters.Add(theater);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}
