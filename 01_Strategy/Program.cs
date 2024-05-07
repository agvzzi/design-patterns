using _01_Strategy.Classes;

namespace _01_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck[] ducks = [new MallardDuck(), new RedheadDuck(), new RubberDuck(), new DecoyDuck()];

            foreach (Duck duck in ducks)
            {
                duck.Display();
                duck.MakeSound();
                duck.PerformFly();
                duck.Swim();
                Console.WriteLine("-----------------------");
            }

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}