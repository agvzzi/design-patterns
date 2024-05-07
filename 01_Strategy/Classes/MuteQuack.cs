using _01_Strategy.Interfaces;

namespace _01_Strategy.Classes
{
    public class MuteQuack : ISoundBehavior
    {
        public void Sound()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}