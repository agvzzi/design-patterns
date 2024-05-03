namespace _01_Strategy.Classes
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            soundBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a redhead");
        }
    }
}