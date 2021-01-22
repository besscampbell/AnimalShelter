using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using APIAnimalShelter.Models;

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
  }
}