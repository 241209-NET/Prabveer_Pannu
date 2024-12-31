using Microsoft.AspNetCore.Mvc;
using PetTracker.API.Model;
using PetTracker.API.Service;

namespace PetTracker.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{   
    private readonly IPetService _petService;

    public PetController(IPetService petService)
    {
        _petService = petService;
    }

    [HttpGet]
    public IActionResult GetAllPets()
    {
        var petList = _petService.GetAllPets();        
        return Ok(petList);
    }

    [HttpPost]
    public IActionResult CreateNewPet(Pet newPet)
    {
        var pet = _petService.CreateNewPet(newPet);
        return Ok(pet);
    }

    [HttpDelete]
    public IActionResult DeletePet(string name)
    {
        throw new NotImplementedException();
    }

    // [HttpDelete]
    // public IActionResult DeletePet(int id)
    // {

    // }
}