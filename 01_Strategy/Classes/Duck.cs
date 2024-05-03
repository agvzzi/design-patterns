using _01_Strategy.Interfaces;

namespace _01_Strategy.Classes
{
    public abstract class Duck
    {
        public IFlyBehavior? flyBehavior;
        public ISoundBehavior? soundBehavior;
        
        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void SetSoundBehavior(ISoundBehavior sb)
        {
            soundBehavior = sb;
        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior?.Fly();
        }

        public void MakeSound()
        {
            soundBehavior?.Sound();
        }

        public void Swim()
        {
            Console.WriteLine("The duck is swimming");
        }
    }
}