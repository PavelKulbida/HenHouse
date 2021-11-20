using Henhouse.Domain;

namespace Henhouse
{
  internal class EggProxy : IEgg
  {
    public IEgg Egg { get; set; }

    public IHen Hatch()
    {
      return Egg.Hatch();
    }
  }
}
