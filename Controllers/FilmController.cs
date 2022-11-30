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
}