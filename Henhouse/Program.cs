using System;
using Henhouse.Domain;

namespace Henhouse
{
  class Program
  {
    static void Main()
    {
      var hen = GetCompositionRoot();

      Console.WriteLine(hen.Say());

      var egg = hen.MakeEegg();

      var chicken = egg.Hatch();

      Console.WriteLine(chicken.Say());
    }

    private static IHen GetCompositionRoot()
    {
      var egg = new Egg(default);
      var hen = new Hen(egg);

      return hen;
    }
  }
}
