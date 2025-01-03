using Microsoft.EntityFrameworkCore;
using PetTracker.API.Model;

namespace PetTracker.API.Data;

public partial class PetContext : DbContext
{
    public PetContext(){}
    public PetContext(DbContextOptions<PetContext> options) : base(options){}

    public virtual DbSet<Pet> Pets { get; set; }
    public virtual DbSet<Employee> Employee { get; set; }
    public virtual DbSet<Manager> Manager { get; set; }
}