using Microsoft.AspNetCore.Mvc;
using LP3_ProjetoFinal.Models;

namespace LP3_ProjetoFinal.Controllers;

public class MovieTheaterController : Controller
{
    // underline pode ser usada se atributo é private
    private readonly ProjContext _context;

    public MovieTheaterController(ProjContext context) 
    {
        _context = context;
    }

    public IActionResult Index() => View(_context.MovieTheaters);
    
}