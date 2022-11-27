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
    ViewBag.products = _context.Products.Where(x => x.StoreId == id).ToList();

        if(store == null)
        {
            return NotFound();
        }

        return View(store);
    }

    public IActionResult Delete(int id)
    {
        Store store = _context.Stores.Find(id);

        if(store == null)
        {
            return NotFound();
        }

        // colocar exceção quando tem produto - foreign key

        _context.Stores.Remove(store);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    

    public IActionResult Create()
    {
        return View();
    }  

    [HttpPost]
    public IActionResult Create([FromForm] Store store)
    {

        if (!ModelState.IsValid)
        {
            return View(store);
        }

        if (_context.Stores.Find(store.Id) != null) 
        {
            throw new Exception("Já existe uma loja com esse Id");
        }

        _context.Stores.Add(store);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Update(int id)
    {
        Store store = _context.Stores.Find(id);
        return View(store);
    }


    [HttpPost]
    public IActionResult Update([FromForm] Store store)
    {
        if (!ModelState.IsValid)
        {
            return View(store);
        }

        Store storeFound = _context.Stores.Find(store.Id);

        if (storeFound == null)
        {
            return NotFound();
        }

        storeFound.Id = store.Id;
        storeFound.Name = store.Name;
        storeFound.Description = store.Description;

        _context.Stores.Update(storeFound);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}