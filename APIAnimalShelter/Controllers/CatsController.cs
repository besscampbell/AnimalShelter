using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using APIAnimalShelter.Models;

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
  }
}