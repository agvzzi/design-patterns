
public class SingleChocolateBoiler
{
    private bool empty;
    private bool boiled;

    private static SingleChocolateBoiler? instance;

    private SingleChocolateBoiler()
    {
        // Initially, the boiler is empty and not boiled
        empty = true;
        boiled = false;
    }

    public static SingleChocolateBoiler Instance
    {
        get
        {
            instance ??= new SingleChocolateBoiler();
            return instance;
        }
    }

    // Add a methiod to fill
    public void Fill()
    {
        if (IsEmpty())
        {
            empty = false;
            boiled = false;
            Console.WriteLine("Fill the boiler with a milk/chocolate mixture");
        }
    }
    
    // Add a method to drain
    public void Drain()
    {
        if (!IsEmpty() && IsBoiled())
        {
            empty = true;
            Console.WriteLine("Drain the boiled milk and chocolate");
        }
    }

    // Add a method to boil
    public void Boil()
    {
        if (!IsEmpty() && !IsBoiled())
        {
            boiled = true;
            Console.WriteLine("Bring the contents to a boil");
        }
    }
    
    public bool IsEmpty()
    {
        return empty;
    }

    public bool IsBoiled()
    {
        return boiled;
    }
}