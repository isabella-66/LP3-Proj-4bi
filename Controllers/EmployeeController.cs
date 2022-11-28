using Microsoft.AspNetCore.Mvc;
using LP3_ProjetoFinal.Models;

namespace LP3_ProjetoFinal.Controllers;

public class EmployeeController : Controller
{
    private readonly ProjContext _context;

    public EmployeeController(ProjContext context) 
    {
        _context = context;
    }

    public IActionResult Index() => View(_context.Employees);

    public IActionResult Create()
    {
        return View();
    }  

    [HttpPost]
    public IActionResult Create([FromForm] Employee employee)
    {
        if (!ModelState.IsValid)
        {
            return View(employee);
        }

        if (_context.Employees.Find(employee.Id) != null) 
        {
            throw new Exception("Já existe um(a) funcionário com esse Id");
        }

        _context.Employees.Add(employee);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}