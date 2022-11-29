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
        // if (!ModelState.IsValid)
        // {
        //     return View(employee);
        // }

        if (_context.Employees.Find(employee.Id) != null) 
        {
            throw new Exception("Já existe um(a) funcionário(a) com esse Id");
        }

        _context.Employees.Add(employee);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Update(int id)
    {
        Employee find = _context.Employees.Find(id);
        return View(find);
    }

    [HttpPost]
    public IActionResult Update([FromForm] Employee employee)
    {
        // if (!ModelState.IsValid)
        // {
        //     return View(employee);
        // }

        Employee employeeFound = _context.Employees.Find(employee.Id);

        if (employeeFound == null)
        {
            return NotFound();
        }

        employeeFound.Id = employee.Id;
        employeeFound.Name = employee.Name;
        employeeFound.Lastname = employee.Lastname;
        employeeFound.Occupation = employee.Occupation;
        employeeFound.EntryTime = employee.EntryTime;
        employeeFound.DepartureTime = employee.DepartureTime;

        _context.Employees.Update(employeeFound);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}