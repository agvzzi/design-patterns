using _01_Strategy.Interfaces;

namespace _01_Strategy.Classes
{
    public class FlyRocketPowered : IFlyBehavior
    {    
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}