using Microsoft.AspNetCore.Mvc;
using LP3_ProjetoFinal.Models;

namespace LP3_ProjetoFinal.Controllers;

public class CleaningTimeController : Controller
{
    private readonly ProjContext _context;

    public CleaningTimeController(ProjContext context)
    {
        _context = context;
    }

    public IActionResult Index() => View(_context.CleaningTimes);
}
