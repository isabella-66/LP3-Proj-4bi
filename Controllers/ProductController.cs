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

    public IActionResult Create(Store store)
    {
        ViewBag.lojaId = store.Id;
        return View();
    }  

    [HttpPost]
    public IActionResult Create([FromForm] Product product)
    {

        if (!ModelState.IsValid)
        {
            return View(product);
        }

        if (_context.Products.Find(product.Id) != null) 
        {
            throw new Exception("Já existe um produto com esse Id");
        }

        _context.Products.Add(product);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Update(int id)
    {
        Product product = _context.Products.Find(id);
        return View(product);
    }

    [HttpPost]
    public IActionResult Update([FromForm] Product product)
    {
        if (!ModelState.IsValid)
        {
            return View(product);
        }

        Product productFound = _context.Products.Find(product.Id);

        if (productFound == null)
        {
            return NotFound();
        }

        productFound.Id = product.Id;
        productFound.Name = product.Name;
        productFound.Price = product.Price;
        productFound.Description = product.Description;
        productFound.Quantity = product.Quantity;
        productFound.StoreId = product.StoreId;

        _context.Products.Update(productFound);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

}