namespace _01_Strategy.Classes
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            SoundBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a redhead");
        }
    }
}