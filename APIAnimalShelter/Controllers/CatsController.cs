using APIAnimalShelter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

    //GET api/cats/
    [HttpGet]
    public ActionResult<IEnumerable<Cat>> Get()
    {
      return _db.Cats.ToList();
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
  }
}