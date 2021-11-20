namespace Henhouse.Domain
{
  public interface IHen
  {
    string Say();

    IEgg MakeEegg();
  }
}