using PetTracker.API.Model;
using PetTracker.API.Repository;

namespace PetTracker.API.Service;

public class PetService : IPetService
{
    private readonly IPetRepository _petRepository;

    public PetService(IPetRepository petRepository) => _petRepository = petRepository;

    public Pet CreateNewPet(Pet newPet)
    {
        return _petRepository.CreateNewPet(newPet);
    }

    public IEnumerable<Pet> GetAllPets()
    {
        return _petRepository.GetAllPets();
    }

    public Pet? GetPetById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Pet> GetPetByName(string name)
    {
        throw new NotImplementedException();
    }

}