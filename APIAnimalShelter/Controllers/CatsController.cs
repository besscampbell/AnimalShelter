using APIAnimalShelter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIAnimalShelter.Controllers
{
  [Route("api/cats")]
  [ApiController]
  public class CatsController : ControllerBase
  {
    private readonly APIAnimalShelterContext _db;
    public CatsController(APIAnimalShelterContext db)
    {
      _db = db;
    }

    //GET api/cats?
    [HttpGet]
    public ActionResult<IEnumerable<Cat>> GetQuery(string name, int age, string sex, string breed, string coloring, DateTime dateAvaiable)
    {
      var query = from c in _db.Cats select c;
      if( name != null)
      {
        query = query.Where(entry => entry.Name.Contains(name));
      }
      if( age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }
      if( sex != null)
      {
        query = query.Where(entry => entry.Sex == sex);
      }
      if( breed != null)
      {
        query = query.Where(entry => entry.Breed.Contains(breed));
      }
      if( coloring != null)
      {
        query = query.Where(entry => entry.Coloring.Contains(coloring));
      }
      return query.ToList();
    }

    //POST api/cats
    [HttpPost]
    public void Post([FromBody] Cat cat)
    {
      _db.Cats.Add(cat);
      _db.SaveChanges();
    }

    //GET api/cats/1
    [HttpGet("{id}")]
    public ActionResult<Cat> Get(int id)
    {
      return _db.Cats.FirstOrDefault(entry => entry.CatId == id);
    }

    //PUT api/cats/1
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Cat cat)
    {
      cat.CatId = id;
      _db.Entry(cat).State = EntityState.Modified;
      _db.SaveChanges();
    }

    //DELETE api/cats/1
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var adoptedCat = _db.Cats.FirstOrDefault(entry => entry.CatId == id);
      _db.Cats.Remove(adoptedCat);
      _db.SaveChanges();
    }

    //GET api/cats/random
    [HttpGet("random")]
    public ActionResult<Cat> GetRandom()
    {
      Random rand = new Random();
      int toSkip = rand.Next(0, _db.Cats.Count());

      var randomCat = _db.Cats.OrderBy(r => Guid.NewGuid()).Skip(toSkip).Take(1).FirstOrDefault();
      return randomCat;
    }
  }
}