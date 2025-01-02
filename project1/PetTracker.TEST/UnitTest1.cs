namespace PetTracker.TEST;

using Moq;
using PetTracker.API.Model;
using PetTracker.API.Repository;
using PetTracker.API.Service;
public class UnitTest1
{
    [Fact]
    public void TestCreateNewPet()
    {
        Mock<IPetRepository> mockRepo = new();
        PetService petservice = new(mockRepo.Object);

        List<Pet> PetList = [
            new Pet {Id = 1, Name = "temp", Team_Id = 1},
            new Pet {Id = 2, Name = "temp2", Team_Id = 1},
            new Pet {Id = 3, Name = "temp3", Team_Id = 1},
        ];

        Pet newpet = new Pet {Id = 4, Name = "temp", Team_Id = 1};
        mockRepo.Setup(repo => repo.CreateNewPet(newpet)).Callback((Pet p) => PetList.Add(p)).Returns(newpet);

        // act
        var myPet = petservice.CreateNewPet(newpet);

        // assert 
        Assert.Contains(newpet, PetList);

    }
    [Fact]
    public void TestGetAllPet()
    {
        //arrange
        Mock<IPetRepository> mockRepo = new();
        PetService petservice = new(mockRepo.Object);

        List<Pet> PetList = [
            new Pet {Id = 1, Name = "temp", Team_Id = 1},
            new Pet {Id = 2, Name = "temp2", Team_Id = 1},
            new Pet {Id = 3, Name = "temp3", Team_Id = 1},
        ];

        mockRepo.Setup(repo => repo.GetAllPets()).Returns(PetList);
        //act
        var result = petservice.GetAllPets().ToList();
        //assert
        Assert.Equal(PetList, result);
    }
    [Fact]
    public void TestCreateNewManager()
    {
        Mock<IManagerRepository> mockRepo = new();
        ManagerService Managerservice = new(mockRepo.Object);

        List<Manager> ManagerList = [
            new Manager {Id = 1, Team_Id = 1, },
            new Manager {Id = 2, Team_Id = 1},
            new Manager {Id = 3, Team_Id = 1},
        ];

        Manager newManager = new Manager {Id = 4, Team_Id = 1, Project_Id = 1};
        mockRepo.Setup(repo => repo.CreateNewManager(newManager)).Callback((Manager p) => ManagerList.Add(p)).Returns(newManager);

        // act
        var myManager = Managerservice.CreateNewManager(newManager);

        // assert 
        Assert.Contains(newManager, ManagerList);

    }
    [Fact]
    public void TestGetAllManager()
    {
        //arrange
        Mock<IManagerRepository> mockRepo = new();
        ManagerService Managerservice = new(mockRepo.Object);

        List<Manager> ManagerList = [
            new Manager {Id = 1, Team_Id = 1, Project_Id = 1},
            new Manager {Id = 2, Team_Id = 1, Project_Id = 2},
            new Manager {Id = 3, Team_Id = 1, Project_Id = 2},
        ];

        mockRepo.Setup(repo => repo.GetAllManagers()).Returns(ManagerList);
        //act
        var result = Managerservice.GetAllManagers().ToList();
        //assert
        Assert.Equal(ManagerList, result);
    }
    [Fact]
    public void TestCreateNewEmployee()
    {
        Mock<IEmployeeRepository> mockRepo = new();
        EmployeeService Employeeservice = new(mockRepo.Object);

        List<Employee> EmployeeList = [
            new Employee {Id = 1, Name = "temp", Team_Id = 1},
            new Employee {Id = 2, Name = "temp2", Team_Id = 1},
            new Employee {Id = 3, Name = "temp3", Team_Id = 1},
        ];

        Employee newEmployee = new Employee {Id = 4, Name = "temp", Team_Id = 1};
        mockRepo.Setup(repo => repo.CreateNewEmployee(newEmployee)).Callback((Employee p) => EmployeeList.Add(p)).Returns(newEmployee);

        // act
        var myEmployee = Employeeservice.CreateNewEmployee(newEmployee);

        // assert 
        Assert.Contains(newEmployee, EmployeeList);

    }
    [Fact]
    public void TestGetAllEmployee()
    {
        //arrange
        Mock<IEmployeeRepository> mockRepo = new();
        EmployeeService Employeeservice = new(mockRepo.Object);

        List<Employee> EmployeeList = [
            new Employee {Id = 1, Name = "temp", Team_Id = 1},
            new Employee {Id = 2, Name = "temp2", Team_Id = 1},
            new Employee {Id = 3, Name = "temp3", Team_Id = 1},
        ];

        mockRepo.Setup(repo => repo.GetAllEmployees()).Returns(EmployeeList);
        //act
        var result = Employeeservice.GetAllEmployees().ToList();
        //assert
        Assert.Equal(EmployeeList, result);
    }
}