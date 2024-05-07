namespace _01_Strategy.Classes
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            soundBehavior = new Quack();
            flyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}