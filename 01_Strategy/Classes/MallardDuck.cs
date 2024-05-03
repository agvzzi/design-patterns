namespace _01_Strategy.Classes
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            SoundBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a mallard");
        }
    }
}