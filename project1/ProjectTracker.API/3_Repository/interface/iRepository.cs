using PetTracker.API.Model;

namespace PetTracker.API.Repository;

public interface IPetRepository
{
    //CRUD
    Pet CreateNewPet(Pet newPet); 
    IEnumerable<Pet> GetAllPets(); 
    Pet? GetPetById(int id); 
    IEnumerable<Pet> GetPetByName(string name);
    void DeletePetById(int id);
}

public interface IEmployeeRepository
{
    //CRUD
    Employee CreateNewEmployee(Employee newEmployee); 
    IEnumerable<Employee> GetAllEmployees(); 
    Employee? GetEmployeeById(int id); 
    IEnumerable<Employee> GetEmployeeByName(string name);
    void DeleteEmployeeById(int id);
}

public interface IManagerRepository
{
    //CRUD
    Manager CreateNewManager(Manager newManager); 
    IEnumerable<Manager> GetAllManagers(); 
    Manager? GetManagerById(int id); 
    IEnumerable<Manager> GetManagerByName(string name);
    void DeleteManagerById(int id);
}
