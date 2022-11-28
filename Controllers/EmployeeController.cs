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
}