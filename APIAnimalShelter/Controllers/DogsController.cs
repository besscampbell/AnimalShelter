using APIAnimalShelter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIAnimalShelter.Controllers
{
  [Route("api/dogs")]
  [ApiController]
  public class DogsController : ControllerBase
  {
    private readonly APIAnimalShelterContext _db;
    public DogsController(APIAnimalShelterContext db)
    {
      _db = db;
    }

    //GET api/dogs/
    [HttpGet]
    public ActionResult<IEnumerable<Dog>> Get()
    {
      return _db.Dogs.ToList();
    }

    //POST api/dogs
    [HttpPost]
    public void Post([FromBody] Dog dog)
    {
      _db.Dogs.Add(dog);
      _db.SaveChanges();
    }

    //GET api/dogs/1
    [HttpGet("{id}")]
    public ActionResult<Dog> Get(int id)
    {
      return _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
    }

    //PUT api/dogs/1
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Dog dog)
    {
      dog.DogId = id;
      _db.Entry(dog).State = EntityState.Modified;
      _db.SaveChanges();
    }

    //DELETE api/dogs/1
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var adoptedDog = _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
      _db.Dogs.Remove(adoptedDog);
      _db.SaveChanges();
    }


    //GET api/dogs/random
    [HttpGet("random")]
    public ActionResult<Dog> GetRandom()
    {
      Random rand = new Random();
      int toSkip = rand.Next(0, _db.Dogs.Count());

      var randomDog = _db.Dogs.OrderBy(r => Guid.NewGuid()).Skip(toSkip).Take(1).FirstOrDefault();
      return randomDog;
    }
  }
}