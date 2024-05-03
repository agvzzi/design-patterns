namespace _01_Strategy.Classes
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            SoundBehavior = new Squeak();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a rubberduck");
        }
    }
}