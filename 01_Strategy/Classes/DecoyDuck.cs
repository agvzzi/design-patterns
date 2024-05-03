namespace _01_Strategy.Classes
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            SoundBehavior = new MuteQuack();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a decoy duck");
        }
    }
}