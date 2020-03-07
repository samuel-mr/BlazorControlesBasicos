using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlesBasicos.Client.Pages.CombosCascade
{
  public class Repositorio
  {

    List<Genero> TablaGeneros()
    {
      return new List<Genero>()
      {
        new Genero(){ Id = 1 , Descripcion = "Estrategia" },
        new Genero(){ Id = 2 , Descripcion = "Shooter" }
      };
    }

    public List<Juego> TablaJuegos()
    {
      return new List<Juego>()
      {
        new Juego(){ Id = 20 , Titulo = "StartCraft", GeneroId = 1 },
        new Juego(){ Id = 21 , Titulo = "WarCraft", GeneroId = 1 },
        new Juego(){ Id = 22 , Titulo = "HalfLife 2", GeneroId = 2 },
        new Juego(){ Id = 23 , Titulo = "Counter Strike", GeneroId = 2 },
        new Juego(){ Id = 24 , Titulo = "OverWatch", GeneroId = 2 },
      };
    }



    public async Task<List<Genero>> GetGeneros()
    {
      await Task.Delay(2000);

      var sql = from j in TablaGeneros()
                select j;

      return sql.ToList();
    }
    public async Task<List<Juego>> GetJuegosByGenero(int generoId)
    {
      await Task.Delay(2000);

      var sql = from j in TablaJuegos()
                where j.GeneroId == generoId
                select j;

      return sql.ToList();
    }



  }
}
