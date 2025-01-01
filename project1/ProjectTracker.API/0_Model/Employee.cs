namespace PetTracker.API.Model;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string? Address { get; set; }
    public string? Role { get; set; }
    public int Salary { get; set; }
    public int Team_Id { get; set; }
    public DateOnly? Birthday { get; set; }
}