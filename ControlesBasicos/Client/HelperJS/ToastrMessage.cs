using Microsoft.JSInterop;
using System.Threading.Tasks;

using System.Text.Json;
using System;

namespace ControlesBasicos.Client.HelperJS
{
  public class ToastrMessage : ILogMessage
  {
    private readonly IJSRuntime js;

    public ToastrMessage(IJSRuntime js)
    {
      this.js = js;
    }

    public async Task Success(string message)
    {
      var config = JsonSerializer.Serialize(new ToastrOptionsInternal());
      Console.WriteLine(config);
      await js.InvokeVoidAsync("toastr.success", message, "", config);
    }
    public async Task Info(string message)
    {
      await js.InvokeVoidAsync("toastr.info", message);
    }
    public async Task Warning(string message)
    {
      await js.InvokeVoidAsync("toastr.warning", message);
    }
    public async Task Error(string message)
    {
      await js.InvokeVoidAsync("toastr.error", message);
    }
  }

  internal class ToastrOptionsInternal
  {
    public bool closeButton { get; set; } = true;
  }
}
