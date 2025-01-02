using PetTracker.API.Data;
using PetTracker.API.Model;

namespace PetTracker.API.Repository;

public class EmployeeRepository : IEmployeeRepository
{
    //Need the DB Object to work with.
    private readonly PetContext _petContext;

    public EmployeeRepository(PetContext petContext) => _petContext = petContext;
    
    public Employee CreateNewEmployee(Employee newEmployee)
    {
        //Insert into Pets Values (newPet)
        _petContext.Employee.Add(newEmployee);
        _petContext.SaveChanges();
        return newEmployee;
    }

    public IEnumerable<Employee> GetAllEmployees()
    {
        return _petContext.Employee.ToList();
    }

    public Employee? GetEmployeeById(int id)
    {
        return _petContext.Employee.FirstOrDefault(p => p.Id ==id);
    }
    public void DeleteEmployeeById(int id)
    {
        var Employee = GetEmployeeById(id);
        _petContext.Employee.Remove(Employee!);
        _petContext.SaveChanges();
    }
    public IEnumerable<Employee> GetEmployeeByName(string name)
    {
        throw new NotImplementedException();
    }

}