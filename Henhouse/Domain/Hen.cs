using System.Text;
using ViennaNET.Utils;

namespace Henhouse.Domain
{
  public class Hen : IHen
  {
    private readonly IEgg _egg;
    
    public Hen(IEgg egg)
    {
      _egg = egg.ThrowIfNull();
    }

    public string Say()
    {
      return "Cococo";
    }

    public IEgg MakeEegg()
    {
      return _egg;
    }
  }
}
