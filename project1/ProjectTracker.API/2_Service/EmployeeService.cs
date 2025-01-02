using PetTracker.API.Model;
using PetTracker.API.Repository;

namespace PetTracker.API.Service;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _EmployeeRepository;

    public EmployeeService(IEmployeeRepository EmployeeRepository) => _EmployeeRepository = EmployeeRepository;

    public Employee CreateNewEmployee(Employee newEmployee)
    {
        return _EmployeeRepository.CreateNewEmployee(newEmployee);
    }

    public IEnumerable<Employee> GetAllEmployees()
    {
        return _EmployeeRepository.GetAllEmployees();
    }

    public Employee? GetEmployeeById(int id)
    {
        if(id < 1)
            return null;
        return _EmployeeRepository.GetEmployeeById(id);
    }
    public Employee? DeleteEmployeeById(int id)
    {
        var Employee = GetEmployeeById(id);
        if(Employee is not null) _EmployeeRepository.DeleteEmployeeById(id);
        return Employee;
    }
    public IEnumerable<Employee> GetEmployeeByName(string name)
    {
        throw new NotImplementedException();
    }

}