using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlesBasicos.Client.Pages.DataBinding.TreeClass
{
  public class Book : IEquatable<Book>
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

    public bool Equals(Book other)
    {
      if (other == null)
        return false;
      if (this.Title == other.Title && this.Year == other.Year)
        return true;

      return false;
    }
  }
}
