// See https://aka.ms/new-console-template for more information
public class ChickenPizzaDecorator : PizzaDecorator
{
    private readonly IPizza pizza;
    public ChickenPizzaDecorator(IPizza pizza)
    {
        this.pizza = pizza;
    }

    public override string CookPizza()
    {
        return pizza.CookPizza() + " , Chicken added";
    }
}
