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

    public IActionResult Show(int id) {
        CleaningTime cleaningTime = _context.CleaningTimes.Find(id);

        if(cleaningTime == null)
        {
            return NotFound();
        }

        return View(cleaningTime);
    }

    public IActionResult Create()
    {
        return View();
    }  

    [HttpPost]
    public IActionResult Create([FromForm] CleaningTime cleaningTime)
    {
        if (!ModelState.IsValid)
        {
            return View(cleaningTime);
        }

        _context.CleaningTimes.Add(cleaningTime);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        CleaningTime cleaningTime = _context.CleaningTimes.Find(id);

        if(cleaningTime == null)
        {
            return NotFound();
        }

        _context.CleaningTimes.Remove(cleaningTime);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Update(int id)
    {
        CleaningTime cleaningTime = _context.CleaningTimes.Find(id);
        return View(cleaningTime);
    }

    [HttpPost]
    public IActionResult Update([FromForm] CleaningTime cleaningTime)
    {
        if (!ModelState.IsValid)
        {
            return View(cleaningTime);
        }
        
        _context.CleaningTimes.Update(cleaningTime);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}
