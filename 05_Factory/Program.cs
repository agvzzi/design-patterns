using _05_Factory.Classes;

namespace _05_Factory;

class Program
{
    static void Main(string[] args)
    {
        NYPizzaStore nyStore = new();
        Pizza pizza = nyStore.OrderPizza("Cheese");
        Console.WriteLine("Ethan ordered a " + pizza.name);

        Console.WriteLine("------------------------------");

        ChicagoPizzaStore chicagoStore = new();
        pizza = chicagoStore.OrderPizza("Cheese");
        Console.WriteLine("Joel ordered a " + pizza.name);
    }
}
