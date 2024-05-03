namespace _04_Factory.Classes;

public class PizzaStore
{
    readonly SimplePizzaFactoy factory;

    public PizzaStore(SimplePizzaFactoy factory)
    {   
        this.factory = factory;
    }
    
    public Pizza OrderPizza(string type)
    {
        Pizza pizza= factory.CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}