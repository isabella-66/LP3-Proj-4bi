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

    public IActionResult Update(int id)
    {
        CleaningTime cleaningTime = _context.CleaningTimes.Find(id);
        return View(cleaningTime);
    }

    [HttpPost]
    public IActionResult Update([FromForm] CleaningTime cleaningTime)
    {
        _context.CleaningTimes.Update(cleaningTime);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}
