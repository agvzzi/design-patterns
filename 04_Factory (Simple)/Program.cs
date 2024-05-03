using _04_Factory.Classes;

namespace _04_Factory;

class Program
{
    static void Main(string[] args)
    {
        SimplePizzaFactoy factory = new();
        PizzaStore store = new(factory);
        store.OrderPizza("Clam");
    }
}