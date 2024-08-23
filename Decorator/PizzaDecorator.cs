// See https://aka.ms/new-console-template for more information
public abstract class PizzaDecorator : IPizza
{
    protected PizzaDecorator()
    {
    }

    public abstract string CookPizza();
}
