using PetTracker.API.Data;
using PetTracker.API.Model;

namespace PetTracker.API.Repository;

public class ManagerRepository : IManagerRepository
{
    //Need the DB Object to work with.
    private readonly PetContext _petContext;

    public ManagerRepository(PetContext petContext) => _petContext = petContext;
    
    public Manager CreateNewManager(Manager newManager)
    {
        //Insert into Pets Values (newPet)
        _petContext.Manager.Add(newManager);
        _petContext.SaveChanges();
        return newManager;
    }

    public IEnumerable<Manager> GetAllManagers()
    {
        return _petContext.Manager.ToList();
    }

    public Manager? GetManagerById(int id)
    {
        return _petContext.Manager.FirstOrDefault(p => p.Id ==id);
    }
    public void DeleteManagerById(int id)
    {
        var Manager = GetManagerById(id);
        _petContext.Manager.Remove(Manager!);
        _petContext.SaveChanges();
    }
    public IEnumerable<Manager> GetManagerByName(string name)
    {
        throw new NotImplementedException();
    }

}