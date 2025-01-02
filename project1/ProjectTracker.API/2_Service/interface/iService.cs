using PetTracker.API.Model;

namespace PetTracker.API.Service;

public interface IPetService
{
    Pet CreateNewPet(Pet newPet);
    IEnumerable<Pet> GetAllPets();
    Pet? GetPetById(int id);
    IEnumerable<Pet> GetPetByName(string name);
    Pet? DeletePetById(int id);
}

public interface IEmployeeService
{
    Employee CreateNewEmployee(Employee newEmployee);
    IEnumerable<Employee> GetAllEmployees();
    Employee? GetEmployeeById(int id);
    IEnumerable<Employee> GetEmployeeByName(string name);
    Employee? DeleteEmployeeById(int id);
}

public interface IManagerService
{
    Manager CreateNewManager(Manager newManager);
    IEnumerable<Manager> GetAllManagers();
    Manager? GetManagerById(int id);
    IEnumerable<Manager> GetManagerByName(string name);
    Manager? DeleteManagerById(int id);
}