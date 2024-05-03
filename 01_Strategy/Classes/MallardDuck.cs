namespace _01_Strategy.Classes
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            soundBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a mallard");
        }
    }
}