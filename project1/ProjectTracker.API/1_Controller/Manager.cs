using Microsoft.AspNetCore.Mvc;
using PetTracker.API.Model;
using PetTracker.API.Service;

namespace PetTracker.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class ManagerController : ControllerBase
{   
    private readonly IManagerService _ManagerService;

    public  ManagerController(IManagerService ManagerService)
    {
        _ManagerService = ManagerService;
    }

    [HttpGet]
    public IActionResult GetAllManagers()
    {
        var ManagerList = _ManagerService.GetAllManagers();        
        return Ok(ManagerList);
    }

    [HttpPost]
    public IActionResult CreateNewManager(Manager newManager)
    {
        var Manager = _ManagerService.CreateNewManager(newManager);
        return Ok(Manager);
    }
     [HttpGet("id")]
     public IActionResult GetManagerById(int id)
     {
        var Manager = _ManagerService.GetManagerById(id);

        if(Manager is null) return NotFound();
        return Ok(Manager);
     }

    [HttpDelete]
    public IActionResult DeleteManager(int id)
    {
        var deleteManager = _ManagerService.DeleteManagerById(id);

        if(deleteManager is null) return NotFound();
        return Ok(deleteManager);
    }

}