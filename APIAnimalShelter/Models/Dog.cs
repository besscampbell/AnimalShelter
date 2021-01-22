using System;

namespace APIAnimalShelter.Models

{
  public class Dog
  {
    public int DogId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }
    public string Breed { get; set; }
    public string Coloring { get; set; }
    public DateTime DateAvailable { get; set; }
    public string Personality { get; set; }
  }
}