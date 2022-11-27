using Microsoft.AspNetCore.Mvc;
using LP3_ProjetoFinal.Models;

namespace LP3_ProjetoFinal.Controllers;

public class ProductController : Controller
{
    private readonly ProjContext _context;

    public ProductController(ProjContext context) 
    {
        _context = context;
    }

    public IActionResult Index() => View(_context.Products);
    
    public IActionResult Delete(int id)
    {
        Product product = _context.Products.Find(id);

        if(product == null)
        {
            return NotFound();
        }

        _context.Products.Remove(product);
        _context.SaveChanges();
        return RedirectToAction("Index"); // mudar
    }

}