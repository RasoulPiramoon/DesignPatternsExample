// See https://aka.ms/new-console-template for more information
public class VegetablePizzaDecorator : PizzaDecorator
{
    private readonly IPizza pizza;

    public VegetablePizzaDecorator(IPizza pizza)
    {
        this.pizza = pizza;
    }

    public override string CookPizza()
    {
        return pizza.CookPizza() + " , Vegetable added";
    }
}
