using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicConcepts.Client.Pages.CombosCascade
{
  public class Genero
  {
    public int Id { get; set; }
    public string Descripcion { get; set; }
  }
  public class Juego
  {
    public int Id { get; set; }
    public string Titulo { get; set; }
    public int GeneroId { get; set; }
  }

  public class Venta
  {
    public int Id { get; set; }
    public int JuegId { get; set; }
    public Juego Juego { get; set; }
    public decimal Monto { get; set; }
  }
}
