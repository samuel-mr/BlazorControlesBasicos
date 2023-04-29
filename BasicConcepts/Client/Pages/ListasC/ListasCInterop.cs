using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesBasicos.Client.Pages.ListasC
{
  public static class ListasCInterop
  {
    internal static ValueTask<object> Focus(IJSRuntime jsRuntime, ElementReference element)
    {
      return jsRuntime.InvokeAsync<object>("blazoredTypeahead.setFocus", element);
    }

    internal static ValueTask<object> AddKeyDownEventListener(IJSRuntime jsRuntime, ElementReference element)
    {
      return jsRuntime.InvokeAsync<object>("blazoredTypeahead.addKeyDownEventListener", element);
    }
    public static async ValueTask Log(this IJSRuntime jsRuntime, string titulo)
    {
      await jsRuntime.InvokeVoidAsync("console.log", titulo);
    }
  }
}
