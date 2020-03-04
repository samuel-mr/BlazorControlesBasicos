using ControlesBasicos.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesBasicos.Server.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class PersonasController : ControllerBase
  {


    [HttpGet("getall")]
    public async Task<ActionResult<List<GetAllPersonItem>>> GetAllPerson()
    {
      var temp = new List<GetAllPersonItem>();
      temp.Add(new GetAllPersonItem() { Id = 1, Nombre = "Sebastian Bach" });
      temp.Add(new GetAllPersonItem() { Id = 2, Nombre = "Johanes Beethoven" });
      temp.Add(new GetAllPersonItem() { Id = 3, Nombre = "Nicollo Paganinni" });
      temp.Add(new GetAllPersonItem() { Id = 4, Nombre = "Sebastian Bach" });
      temp.Add(new GetAllPersonItem() { Id = 5, Nombre = "Johanes Beethoven" });
      temp.Add(new GetAllPersonItem() { Id = 6, Nombre = "Nicollo Paganinni" });
      temp.Add(new GetAllPersonItem() { Id = 7, Nombre = "Sebastian Bach" });
      temp.Add(new GetAllPersonItem() { Id = 8, Nombre = "Johanes Beethoven" });
      temp.Add(new GetAllPersonItem() { Id = 9, Nombre = "Nicollo Paganinni" });
      temp.Add(new GetAllPersonItem() { Id = 10, Nombre = "Sebastian Bach" });
      temp.Add(new GetAllPersonItem() { Id = 11, Nombre = "Johanes Beethoven" });
      temp.Add(new GetAllPersonItem() { Id = 12, Nombre = "Nicollo Paganinni" });
      temp.Add(new GetAllPersonItem() { Id = 13, Nombre = "Sebastian Bach" });
      temp.Add(new GetAllPersonItem() { Id = 14, Nombre = "Johanes Beethoven" });
      temp.Add(new GetAllPersonItem() { Id = 15, Nombre = "Nicollo Paganinni" });
      temp.Add(new GetAllPersonItem() { Id = 16, Nombre = "Sebastian Bach" });
      temp.Add(new GetAllPersonItem() { Id = 17, Nombre = "Johanes Beethoven" });
      temp.Add(new GetAllPersonItem() { Id = 18, Nombre = "Nicollo Paganinni" });
      return temp;
    }
  }
}
