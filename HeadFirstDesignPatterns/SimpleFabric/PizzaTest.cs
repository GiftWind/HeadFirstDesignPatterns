using System;

namespace FabricMethod
{
    class PizzaTest
    {
        public static void Main()
        {
            PizzaStore NYStore = new NYStylePizzaStore();
            PizzaStore ChicagoStore = new ChicagoStylePizzaStore();

            Pizza pizza = NYStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.Name}.");

            pizza = ChicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.Name}.");

            Console.ReadLine();

        }
    }
}
