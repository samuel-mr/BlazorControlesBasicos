using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts.Client.HelperJS
{
    public interface IInteractionMessage
  {
    Task ShowErrorMessage(string mensaje);
    Task ShowErrorMessage(string title, string mensaje);
    Task ShowOkMessage(string mensaje);
    Task ShowOkMessage(string title, string mensaje);
  }
}
