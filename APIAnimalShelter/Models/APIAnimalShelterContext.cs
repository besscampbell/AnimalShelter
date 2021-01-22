using Microsoft.EntityFrameworkCore;

namespace APIAnimalShelter.Models
{
  public class APIAnimalShelterContext : DbContext
  {
    public APIAnimalShelterContext(DbContextOptions<APIAnimalShelterContext> options)
      : base(options)
    {
    }

    public DbSet<Dog> Dogs { get; set; }
    public DbSet<Cat> Cats { get; set; }
  }
}