using System;

namespace AbstractFactory
{
    class ClamPizza : Pizza
    {
        
        readonly IPizzaIngredientFactory _ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {this.Name}");
            this.Dough = _ingredientFactory.CreateDough();
            this.Sauce = _ingredientFactory.CreateSauce();
            this.Cheese = _ingredientFactory.CreateCheese();
            this.Clams = _ingredientFactory.CreateClams();
        }
    }
}
