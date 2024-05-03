using _01_Strategy.Interfaces;

namespace _01_Strategy.Classes
{
    public abstract class Duck
    {
        public IFlyBehavior? FlyBehavior { get; set; }
        public ISoundBehavior? SoundBehavior { get; set; }
        
        public void SetFlyBehavior(IFlyBehavior fb)
        {
            FlyBehavior = fb;
        }

        public void SetSoundBehavior(ISoundBehavior sb)
        {
            SoundBehavior = sb;
        }

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior?.Fly();
        }

        public void MakeSound()
        {
            SoundBehavior?.Sound();
        }

        public void Swim()
        {
            Console.WriteLine("The duck is swimming");
        }
    }
}