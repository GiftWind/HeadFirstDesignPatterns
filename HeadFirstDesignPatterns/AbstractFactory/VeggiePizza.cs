using System;

namespace AbstractFactory
{
    internal class VeggiePizza : Pizza
    {
        readonly IPizzaIngredientFactory _ingredientFactory;

        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {this.Name}");
            this.Dough = _ingredientFactory.CreateDough();
            this.Sauce = _ingredientFactory.CreateSauce();
            this.Veggies = _ingredientFactory.CreateVeggies();

        }
    }
}