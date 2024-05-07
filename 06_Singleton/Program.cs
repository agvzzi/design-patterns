namespace _06_Singleton;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Chocolate Boiler 1:");
        ChocolateBoiler chocolateBoiler1 = new();
        chocolateBoiler1.Fill();
        chocolateBoiler1.Boil();
        Console.WriteLine("--------------------------");
        Console.WriteLine("Chocolate Boiler 2:");
        ChocolateBoiler chocolateBoiler2 = new();
        chocolateBoiler2.Fill();
        chocolateBoiler2.Boil();
        chocolateBoiler2.Drain();

        Console.WriteLine("--------------------------");
        
        Console.WriteLine("Single Chocolate Boiler 1:");
        SingleChocolateBoiler singleChocolateBoiler = SingleChocolateBoiler.Instance;
        singleChocolateBoiler.Fill();
        singleChocolateBoiler.Boil();
        Console.WriteLine("--------------------------");
        Console.WriteLine("Single Chocolate Boiler 2:");
        singleChocolateBoiler.Fill();
        singleChocolateBoiler.Boil();
        singleChocolateBoiler.Drain();
    }
}
