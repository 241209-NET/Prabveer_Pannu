using PetTracker.API.Model;
using PetTracker.API.Repository;

namespace PetTracker.API.Service;

public class ManagerService : IManagerService
{
    private readonly IManagerRepository _ManagerRepository;

    public ManagerService(IManagerRepository ManagerRepository) => _ManagerRepository = ManagerRepository;

    public Manager CreateNewManager(Manager newManager)
    {
        return _ManagerRepository.CreateNewManager(newManager);
    }

    public IEnumerable<Manager> GetAllManagers()
    {
        return _ManagerRepository.GetAllManagers();
    }

    public Manager? GetManagerById(int id)
    {
        if(id < 1)
            return null;
        return _ManagerRepository.GetManagerById(id);
    }
    public Manager? DeleteManagerById(int id)
    {
        var Manager = GetManagerById(id);
        if(Manager is not null) _ManagerRepository.DeleteManagerById(id);
        return Manager;
    }
    public IEnumerable<Manager> GetManagerByName(string name)
    {
        throw new NotImplementedException();
    }

}