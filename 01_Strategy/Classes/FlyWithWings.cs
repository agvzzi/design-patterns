using _01_Strategy.Interfaces;

namespace _01_Strategy.Classes
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("The duck is flying with wings");
        }
    }
}