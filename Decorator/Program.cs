// See https://aka.ms/new-console-template for more information

IPizza pizza = new PlainPizza();
Console.WriteLine("Our menu: plainPizza: enter p, ChickenPizza: enter c, VegetablePIzza: enter v. please order your pizza.");
Console.WriteLine("For exit enter e");
var key = Console.ReadKey().Key.ToString();
Console.WriteLine();
if (key.ToLower() == "p")
{
    Console.WriteLine(pizza.CookPizza());
    Console.ReadKey();
}
else if (key.ToLower() == "c")
{
    PizzaDecorator chickenPizza = new ChickenPizzaDecorator(pizza);
    Console.WriteLine(chickenPizza.CookPizza());
    Console.ReadKey();
}
else if (key.ToLower() == "v")
{
    PizzaDecorator vegetablePizza = new VegetablePizzaDecorator(pizza);
    Console.WriteLine(vegetablePizza.CookPizza());
    Console.ReadKey();
}

