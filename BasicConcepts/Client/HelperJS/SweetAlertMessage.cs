using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts.Client.HelperJS
{
  public class SweetAlertMessage : IInteractionMessage
  {
    private readonly IJSRuntime js;

    public SweetAlertMessage(IJSRuntime js)
    {
      this.js = js;
    }
    public async Task ShowErrorMessage(string mensaje)
    {
      await ShowErrorMessage("Error", mensaje);
    }
    public async Task ShowErrorMessage(string title, string mensaje)
    {
      await ShowMessage(title, mensaje, SweetAlertIcon.error);
    }
    public async Task ShowOkMessage(string mensaje)
    {
      await ShowOkMessage("Exitoso", mensaje);
    }
    public async Task ShowOkMessage(string title, string mensaje)
    {
      await ShowMessage(title, mensaje, SweetAlertIcon.success);
    }

    private async ValueTask ShowMessage(string titulo, string mensaje, SweetAlertIcon tipo)
    {
      await js.InvokeVoidAsync("Swal.fire", titulo, mensaje, Enum.GetName(typeof(SweetAlertIcon), tipo));
    }

    public enum SweetAlertIcon
    {
      warning,
      error,
      success,
      info,
      question
    }
  }
}
