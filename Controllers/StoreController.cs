using Microsoft.AspNetCore.Mvc;
using LP3_ProjetoFinal.Models;

namespace LP3_ProjetoFinal.Controllers;

public class StoreController : Controller
{
    private readonly ProjContext _context;

    public StoreController(ProjContext context) 
    {
        _context = context;
    }

    public IActionResult Index() => View(_context.Stores);

    public IActionResult Show(int id) {
    Store store = _context.Stores.Find(id);

        if(store == null)
        {
            return NotFound();
        }

        return View(store);
    }
    
}