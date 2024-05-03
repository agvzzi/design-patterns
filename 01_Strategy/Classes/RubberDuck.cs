namespace _01_Strategy.Classes
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            soundBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a rubberduck");
        }
    }
}