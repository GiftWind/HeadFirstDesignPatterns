using System;

namespace AbstractFactory
{
    class PizzaStoreDemo
    {
        static void Main()
        {
            PizzaStore pizzaStore = new NYPizzaStore();
            Pizza pizza = pizzaStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.Name}");
            Console.WriteLine();

            pizzaStore = new ChicagoPizzaStore();
            pizza = pizzaStore.OrderPizza("clam");
            Console.WriteLine($"Joel ordered a {pizza.Name}");
            Console.ReadLine();
            
        }
    }
}
