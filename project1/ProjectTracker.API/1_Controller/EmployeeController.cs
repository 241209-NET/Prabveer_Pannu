using Microsoft.AspNetCore.Mvc;
using PetTracker.API.Model;
using PetTracker.API.Service;

namespace PetTracker.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{   
    private readonly IEmployeeService _EmployeeService;

    public EmployeeController(IEmployeeService EmployeeService)
    {
        _EmployeeService = EmployeeService;
    }

    [HttpGet]
    public IActionResult GetAllEmployees()
    {
        var EmployeeList = _EmployeeService.GetAllEmployees();        
        return Ok(EmployeeList);
    }

    [HttpPost]
    public IActionResult CreateNewEmployee(Employee newEmployee)
    {
        var Employee = _EmployeeService.CreateNewEmployee(newEmployee);
        return Ok(Employee);
    }
     [HttpGet("id")]
     public IActionResult GetEmployeeById(int id)
     {
        var Employee = _EmployeeService.GetEmployeeById(id);

        if(Employee is null) return NotFound();
        return Ok(Employee);
     }

    [HttpDelete]
    public IActionResult DeleteEmployee(int id)
    {
        var deleteEmployee = _EmployeeService.DeleteEmployeeById(id);

        if(deleteEmployee is null) return NotFound();
        return Ok(deleteEmployee);
    }

}