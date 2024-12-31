using PetTracker.API.Data;
using PetTracker.API.Model;

namespace PetTracker.API.Repository;

public class PetRepository : IPetRepository
{
    //Need the DB Object to work with.
    private readonly PetContext _petContext;

    public PetRepository(PetContext petContext) => _petContext = petContext;
    
    public Pet CreateNewPet(Pet newPet)
    {
        //Insert into Pets Values (newPet)
        _petContext.Pets.Add(newPet);
        _petContext.SaveChanges();
        return newPet;
    }

    public IEnumerable<Pet> GetAllPets()
    {
        return _petContext.Pets.ToList();
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