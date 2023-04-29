using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlesBasicos.Client.Pages.DataBinding.Tree
{
  public class Book
  {

    private string title = "";
    public string Title
    {
      get
      {
        return title;
      }
      set
      {
        if (title != value)
        {
          title = value;
        }
      }
    }

    private int _year;
    public int Year
    {
      get
      {
        return _year;
      }
      set
      {
        if (_year != value)
        {
          _year = value;
        }
      }
    }

  }
}
