using System;

namespace AbstractFactory
{
    abstract class Pizza
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public Veggies[] Veggies { get; set; }
        public Cheese Cheese { get; set; }
        public Pepperoni Pepperoni { get; set; }
        public Clams Clams { get; set; }

        public abstract void Prepare();

        void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        

    }
}
