using System;
using System.Collections;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public ArrayList Toppings = new ArrayList(); 

        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}...");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce");
            Console.WriteLine("Adding toppings:");
            foreach (var top in Toppings)
            {
                Console.WriteLine(top);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

       
    }
}