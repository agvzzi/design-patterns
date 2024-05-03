using System.Collections;

namespace _05_Factory.Classes;

public abstract class Pizza
{
    public string? name;
    public string? dough;
    public string? sauce;
    public ArrayList toppings = new();
    
    public virtual void Prepare()
    {
        Console.WriteLine("Preparing " + name);
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Adding sauce...");
        Console.WriteLine("Adding toppings:");
        for (int i = 0; i < toppings.Count; i++)
        {
            Console.WriteLine("   " + toppings[i]);
        }
    }

    public virtual void Bake()
    {
        Console.WriteLine("Baking for 25 minutes at 350");   
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cutting the Pizza into diagonal slices");
    }

    public virtual void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }
}