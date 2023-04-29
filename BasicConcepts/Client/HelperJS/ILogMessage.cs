using System.Threading.Tasks;

namespace ControlesBasicos.Client.HelperJS
{
  public interface ILogMessage
  {
    Task Error(string message);
    Task Info(string message);
    Task Success(string message);
    Task Warning(string message);
  }
}