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

        if (cleaningTime.StartTime > cleaningTime.EndTime)
        {
            throw new Exception("O horário de início da limpeza não pode ser posterior ao horário de término");
        }

        if (cleaningTime.StartTime == cleaningTime.EndTime)
        {
            throw new Exception("Os horários de início e término da limpeza não podem ser iguais");
        }

        if(cleaningTime.EndTime.Subtract(cleaningTime.StartTime).Minutes < 30 || cleaningTime.EndTime.Subtract(cleaningTime.StartTime).Minutes > 60)
        {
            throw new Exception("O tempo de limpeza deve ser realizado entre 30 a 60 minutos");
        }

        if (_context.CleaningTimes.Find(cleaningTime.Id) != null) 
        {
            throw new Exception($"Já existe um horário cadastrado com o id {cleaningTime.Id}");
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

        if (cleaningTime.StartTime > cleaningTime.EndTime)
        {
            throw new Exception("O horário de início da limpeza não pode ser posterior ao horário de término");
        }

        if (cleaningTime.StartTime == cleaningTime.EndTime)
        {
            throw new Exception("Os horários de início e término da limpeza não podem ser iguais");
        }

        if(cleaningTime.EndTime.Subtract(cleaningTime.StartTime).Minutes < 30 || cleaningTime.EndTime.Subtract(cleaningTime.StartTime).Minutes > 60)
        {
            throw new Exception("O tempo de limpeza deve ser realizado entre 30 a 90 minutos");
        }
        
        _context.CleaningTimes.Update(cleaningTime);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}
