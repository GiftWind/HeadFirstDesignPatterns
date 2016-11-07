using System;

namespace FactoryMethod
{
    class PizzaTest
    {
        public static void Main()
        {
            PizzaStore NYStore = new NYStylePizzaStore();
            PizzaStore ChicagoStore = new ChicagoStylePizzaStore();

#pragma warning disable RECS0091 // Use 'var' keyword when possible
            Pizza pizza = NYStore.OrderPizza("cheese");
#pragma warning restore RECS0091 // Use 'var' keyword when possible
            Console.WriteLine($"Ethan ordered a {pizza.Name}.");

            pizza = ChicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.Name}.");

            Console.ReadLine();

        }
    }
}
