using ViennaNET.Utils;

namespace Henhouse.Domain
{
  public class Egg : IEgg
  {
    private readonly IHen _hen;

    public Egg(IHen hen)
    {
      _hen = hen.ThrowIfNull();
    }

    public IHen Hatch()
    {
      return _hen;
    }
  }
}
