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
    
}