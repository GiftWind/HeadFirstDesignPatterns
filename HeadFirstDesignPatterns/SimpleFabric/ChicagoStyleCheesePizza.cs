using System;

namespace FactoryMethod
{
    internal class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            this.Name = "Chicago Style Deep Dish Pizza";
            this.Dough = "Extra Thick Crust Dough";
            this.Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}