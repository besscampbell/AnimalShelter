using Microsoft.EntityFrameworkCore;
using System;

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

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Cat>()
        .HasData(
          new Cat { CatId = 1, Name = "Boots", Age = 3, Sex = "Male", Breed = "DSH", Coloring = "Tuxedo", DateAvailable = DateTime.Now, Personality = "Boots is very curious. He plays well with cats and dogs but does not do well around children." },
          new Cat { CatId = 2, Name = "Snowball", Age = 0, Sex = "Female", Breed = "Bombay", Coloring = "Black", DateAvailable = DateTime.Now, Personality = "Snowball is 6 months old and ready for a playmate. She is very funny and acrobatic." },
          new Cat { CatId = 3, Name = "Agatha", Age = 12, Sex = "Female", Breed = "Persian", Coloring = "Grey", DateAvailable = DateTime.Now, Personality = "Agatha is a senior cat looking for her furrever lap. She loves snuggles and head pets" },
          new Cat { CatId = 4, Name = "Robert", Age = 4, Sex = "Male", Breed = "Siamese/DSH", Coloring = "Flame Point", DateAvailable = DateTime.Now, Personality = "Robert loves playing tag but can get a little rowdy in his play. Might not do well around children." },
          new Cat { CatId = 5, Name = "Squish", Age = 7, Sex = "Male", Breed = "Scottish Fold", Coloring = "Silver", DateAvailable = DateTime.Now, Personality = "Squish is the best. You all are crazy if you don't try to adopt this cat right now." }
        );
      builder.Entity<Dog>()
        .HasData(
          new Dog { DogId = 1, Name = "Jackson", Age = 6, Sex = "Male", Breed = "American Pit Bull", Coloring = "Blue grey, white", DateAvailable = DateTime.Now, Personality = "Jackson gets easily frustrated and can exhibit this in a variety of ways. He will need positive outlets for his energy and a calm environment."},
          new Dog { DogId = 2, Name = "Chickie", Age = 2, Sex = "Female", Breed = "Mastiff", Coloring = "Tan, black", DateAvailable = DateTime.Now, Personality = "Chickie will flourish in a calm environment and a low-traffic home. She can be worried about new people, new surroundings and touch. She prefers to take things at her own pace."},
          new Dog { DogId = 3, Name = "Miss Precious", Age = 3, Sex = "Female", Breed = "Chihuahua/Dachshund", Coloring = "TriColor", DateAvailable = DateTime.Now, Personality = "Miss Precious has a history of biting a person or another animal. She would do best in an adult only home"},
          new Dog { DogId = 4, Name = "Zeus", Age = 2, Sex = "Male", Breed = "Rottweiler", Coloring = "Black, Tan", DateAvailable = DateTime.Now, Personality = "Zeus had a growth mindset and loves to learn. He needs positive outlets for his energy and a calm environment."},
          new Dog { DogId = 5, Name = "Uma", Age = 10, Sex = "Female", Breed = "Pointer/American Pit Bull", Coloring = "White, Tan", DateAvailable = DateTime.Now, Personality = "Although Uma is no longer a puppy, she is still active and enjoys going for daily walks or runs. When she's not out and about, you can find her napping on a dog bed or a couch."}
        ); 
    }
  }
}