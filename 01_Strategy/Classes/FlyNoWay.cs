using _01_Strategy.Interfaces;

namespace _01_Strategy.Classes
{
    public class FlyNoWay : IFlyBehavior
    {    
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}