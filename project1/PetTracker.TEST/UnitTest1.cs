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
}