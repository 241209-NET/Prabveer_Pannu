using Microsoft.AspNetCore.Mvc;
using PetTracker.API.Model;
using PetTracker.API.Service;

namespace PetTracker.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class ManagerController : ControllerBase
{   
    private readonly IPetService _petService;

    public  ManagerController(IPetService petService)
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
     [HttpGet("id")]
     public IActionResult GetPetById(int id)
     {
        var Pet = _petService.GetPetById(id);

        if(Pet is null) return NotFound();
        return Ok(Pet);
     }

    [HttpDelete]
    public IActionResult DeletePet(int id)
    {
        var deletePet = _petService.DeletePetById(id);

        if(deletePet is null) return NotFound();
        return Ok(deletePet);
    }

}