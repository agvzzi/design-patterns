using _01_Strategy.Interfaces;

namespace _01_Strategy.Classes
{
    public class Squeak : ISoundBehavior
    {
        public void Sound()
        {
            Console.WriteLine("The duck says: squeak");
        }
    }
}